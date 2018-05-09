using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Rock 
    {
        public int X;
        public int Y;
        public Bitmap image;
        public int height;
        public int width;
        public Rectangle rectangle { get { return new Rectangle(X, Y, width, height); } }
        private bool disposed = false;

        public Rock(int X, int Y, int height, int width, Bitmap image)
        {
            this.X = X;
            this.Y = Y;
            this.height = height;
            this.width = width;
            this.image = image;
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
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                image.Dispose();
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~Rock()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
    }
}

