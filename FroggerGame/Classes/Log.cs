using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Log : Box
    {
        public bool isLeft;
        public bool isSafe;
        public Log(int windowHeight, int windowWidth, int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image, bool isLeft,bool isSafe)
            : base(windowHeight, windowWidth, boxHeight, boxWidth, posX, posY, speed, image)
        {
            this.isLeft = isLeft;
            this.isSafe = isSafe;
        }
        public override void moveUp()
        {
        }
        public override void moveDown()
        {
        }
        public override void moveLeft()
        {
            if (posX <= -100) posX = windowWidth + 100;
            else posX -= speed;
        }
        public override void moveRight()
        {
            if (posX + speed >= windowWidth+100) posX = -100;
            else posX += speed;
        }
        public override void move()
        {
            if (isLeft) moveLeft();
            else moveRight();
        }
        public static List<Box> createBox(int windowHeight, int windowWidth, int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image, bool isLeft, int numOfBoxes, Random rand)
        {
            List<Box> list = new List<Box>(); 
            int speeds = rand.Next(10, 30);
            int size = rand.Next(80, 150);
            int pos = rand.Next(0, windowWidth);
            int offset = rand.Next(size+20, 200);

            for (int i = 0; i < numOfBoxes; i++)
            {
                bool safe = true;
                double num = rand.NextDouble();
                if (num > 0.8 && numOfBoxes>1 && i!=0)
                {
                    safe = false;
                    image = Properties.Resources.burninglog;
                }
                list.Add(new Log(windowHeight, windowWidth, boxHeight, size, pos, posY, speeds, image, isLeft,safe));
                pos += offset;
            }
            return list;
        }
    }
}
