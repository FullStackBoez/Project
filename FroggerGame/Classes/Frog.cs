using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Frog : Box
    {
        // This class defines the palyer and allows control over the frog and other features.

        public Log log;
        public bool dead;

        public Frog(int windowHeight, int windowWidth, int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image)
            : base(windowHeight, windowWidth, boxHeight, boxWidth, posX, posY, speed, image)
        {
            log = null;
            dead = false;
        }
        public override void moveUp()
        {
            image = Properties.Resources.frogUp;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            if (posY <= 0) return;
            else posY -= speed;
        }
        public override void moveDown()
        {
            image = Properties.Resources.frogDown;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            if (posY + speed >= windowHeight) return;
            else posY += speed;
        }
        public override void moveLeft()
        {
            image = Properties.Resources.frogLeft;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            if (posX <= 0) return;
            else posX -= speed;
        }
        public override void moveRight()
        {
            image = Properties.Resources.frogRight;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            if (posX + speed >= windowWidth) return;
            else posX += speed;
        }
        public override void move()
        {
            image = Properties.Resources.frogUp;
            Color col = image.GetPixel(1, 1);
            image.MakeTransparent(col);
            if (log != null)
                if (!log.isLeft)
                    if (posX + boxWidth >= windowWidth) detach();
                    else posX += log.speed;

            if (log != null)
                if (log.isLeft)
                    if (posX <= 0) detach();
                    else posX -= log.speed;
        }
        public void attach(Log l)
        {
            
            if (l.isSafe)
            log = l;
            else dead=true;
        }
        public void detach()
        {
           
            log = null;
        }
        public bool crash(Box c)
        {
            int left = posX;
            int right = posX + boxWidth;
            int top = posY;
            int bottom = posY + boxHeight;

            int cleft = c.posX;
            int cright = c.posX + c.boxWidth;
            int ctop = c.posY;
            int cbottom = c.posY + c.boxHeight;

            return !(left >= cright || right <= cleft || top >= cbottom || bottom <= ctop);
        }
        public bool onLog(Box c)
        {
            int left = posX;
            int right = posX + boxWidth;
            int top = posY;
            int bottom = posY + boxHeight;

            int cleft = c.posX;
            int cright = c.posX + c.boxWidth;
            int ctop = c.posY;
            int cbottom = c.posY + c.boxHeight;

            return !(left >= cright-20 || right-20 <= cleft || top >= cbottom || bottom <= ctop);
        }
    }
}
