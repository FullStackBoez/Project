using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Lane : IDisposable
    {
        // This class creates the main components of the main grid view, also determins if a lane is safe or not and forms the background image.
        // Has 30% chance of being safe.
        private int defaultBoxWidth = 40;
        private int defaultBoxHeight = 40;
        private int posX; 
        private int posY;
        private bool isSafe;
        private int width;
        private int height;
        private int type;
        private int windowHeight;
        private int windowWidth;
        private bool disposed = false;
        private Bitmap laneImage;
        private List<Box> boxes;
        public PowerUps powerup;
        public Rock rock;

        public Bitmap laneBitmap { get { return laneImage; } }
        public Rectangle laneRectangle { get { return new Rectangle(posX,posY,width,height); } }
        public List<Box> lineBox { get { return boxes; } set { boxes = value; } }
        public int Type { get { return type; } }
        public int Y { get { return posY; } set { posY = value; } }

        public Lane(int posX, int posY, int height, int width,int windowHeight,int windowWidth)
        {
            this.height = height;
            this.width = width;
            this.posX = posX;
            this.posY = posY;
            this.windowHeight = windowHeight;
            this.windowWidth = windowWidth;
            this.type = 0;
            isSafe = true;
            laneImage = Properties.Resources.grass;
            boxes = null;
        }
        public Lane(int posX, int posY, int height, int width,Random rand,int windowHeight,int windowWidth)
        {
            this.height=height;
            this.width = width;
            this.posX = posX;
            this.posY = posY;
            this.windowHeight = windowHeight;
            this.windowWidth = windowWidth;
            double num = rand.NextDouble();
            int numberOfBoxes = rand.Next(1, 4);
            if (num > 0.7)
            {
                this.type = 0;
                isSafe = true;
                laneImage = Properties.Resources.grass;
                boxes = null;
                // random generation of rocks (chooses whether or not this safe lane will have a rock)
                num = rand.NextDouble();
                if (num > 0.7)
                {
                    int X = rand.Next(60, windowWidth - 60);
                    rock = new Rock(X, Y, defaultBoxHeight, defaultBoxWidth, Properties.Resources.rock);
                    WindowGrid.rockList.Add(rock);
                }
                else rock = null;
            }
            else
            {
                num = rand.NextDouble();
                isSafe = false;
                if(num > 0.6)
                {
                    createVehicle(rand,numberOfBoxes);
                }
                else
                {
                    createLogs(rand,numberOfBoxes);
                }

            }
            // random generation for power ups (chooses whether or not this lane will have a power up)
            num = rand.NextDouble();
            if (num > 0.7)
            {
                int X = rand.Next(60, windowWidth - 60);
                powerup = new PowerUps(X, Y, rand);
                if (rock != null && powerup.hitsRock(rock)) powerup.X -= 40;
            }
            else powerup = null;
        }
        public void deletePowerUp()
        {
            powerup.Dispose();
            powerup = null;
        }
        private void createVehicle(Random rand,int numberOfBoxes)
        {
            laneImage = Properties.Resources.asphalt;
            double num = rand.NextDouble();
            bool isLeft = false;
            this.type = 1;
            if (num > 0.5) isLeft = true;
            boxes = Vehicle.createBox(windowHeight,windowWidth, defaultBoxHeight, defaultBoxWidth, 0,posY,0,Properties.Resources.carLeft,isLeft,numberOfBoxes,rand);
        }
        private void createLogs(Random rand, int numberOfBoxes)
        {
            laneImage = Properties.Resources.water;
            double num = rand.NextDouble();
            bool isLeft = false;
            this.type = 2;
            if (num > 0.5) isLeft = true;
            boxes = Log.createBox(windowHeight, windowWidth, defaultBoxHeight, defaultBoxWidth, 0, posY, 0, Properties.Resources.log, isLeft, numberOfBoxes, rand);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                laneImage.Dispose();
                laneBitmap.Dispose();
                if(type!=0)
                foreach (Box b in boxes)
                    b.Dispose();
                if (powerup != null)
                {
                    powerup.Dispose();
                    powerup = null;
                }
                if (rock != null)
                {
                    WindowGrid.rockList.Remove(rock);
                    rock.Dispose();
                    rock = null;
                }
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~Lane()
        {
            // Simply call Dispose(false).

            Dispose(false);
        }
    }
}

