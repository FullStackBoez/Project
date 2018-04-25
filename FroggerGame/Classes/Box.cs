using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
   abstract class Box : IDisposable
    {
        // This class acts as a base clase for the vehicle , log and frog classes.
        public int windowHeight;
        public int windowWidth;
        public int posX;
        public int posY;
        public int speed;
        public int boxWidth;
        public int boxHeight;
        private bool disposed = false;
        protected Bitmap image;

        public Bitmap boxImage { get {
                return image;
            } set { image = value; } } 
        public Rectangle boxRectangle { get { return new Rectangle(posX,posY,boxWidth,boxHeight); } }
        public int Y { get { return posY; } set { posY = value; } }

        public Box(int windowHeight, int windowWidth,int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image)
        {
            this.windowHeight = windowHeight;
            this.windowWidth = windowWidth;
            this.boxHeight = boxHeight;
            this.boxWidth = boxWidth;
            this.posX = posX;
            this.posY = posY;
            this.speed = speed;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            this.image = image;
        }
        public abstract void moveUp();
        public abstract void moveDown();
        public abstract void moveLeft();
        public abstract void moveRight();
        public abstract void move();

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
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                image.Dispose();
                boxImage.Dispose();
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~Box()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
    }
}

