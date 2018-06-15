using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    enum Powers { EXTRA_LIFE, SUPER_JUMP, INVINCIBILITY, DOUBLE_POINTS, MYSTERYBOX }
    class PowerUps
    {
        public Powers power;
        public int X;
        public int Y;
        private Log log;
        public Bitmap image;
        private bool disposed = false;
        private int defaultWidth = 40;
        private int defaultHeight = 40;
        public Rectangle rectangle { get { return new Rectangle(X, Y, defaultWidth, defaultHeight); } }

        public PowerUps(int X, int Y,Random rand)
        {
            this.X = X;
            this.Y = Y;
            int ran = rand.Next(0, 5);
            switch (ran)
            {
                case 0:power = Powers.EXTRA_LIFE;
                    image = Properties.Resources.extraLife;
                    break;
                case 1:
                    power = Powers.SUPER_JUMP;
                    image = Properties.Resources.extraJump;
                    break;
                case 2:
                    power = Powers.INVINCIBILITY;
                    image = Properties.Resources.invincibility;
                    break;
                case 3:
                    power = Powers.DOUBLE_POINTS;
                    image = Properties.Resources.doublePointsReserve;
                    break;
                case 4:
                    power = Powers.MYSTERYBOX;
                    image = Properties.Resources.chest;
                    openChest();
                    break;
                   
            }

        }
        private void openChest()
        {
            Random rand = new Random();
            int ran = rand.Next(0, 4);
            switch (ran)
            {
                case 0:
                    power = Powers.EXTRA_LIFE;
                    break;
                case 1:
                    power = Powers.SUPER_JUMP;
                    break;
                case 2:
                    power = Powers.INVINCIBILITY;
                    break;
                case 3:
                    power = Powers.DOUBLE_POINTS;
                    break;
            }
            }
        public void attatch(Log log)
        {
            this.log = log;
        }
        public void move()
        {
            if (log.isLeft) Y -= log.speed;
            else Y += log.speed;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public bool hitsRock(Rock c)
        {
            int left = X;
            int right = X + defaultWidth;
            int top = Y;
            int bottom = Y + defaultHeight;

            int cleft = c.X;
            int cright = c.X + c.width;
            int ctop = c.Y;
            int cbottom = c.Y + c.height;

            return !(left + 30 >= cright || right <= cleft || top >= cbottom || bottom <= ctop);
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
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~PowerUps()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
    }
}
