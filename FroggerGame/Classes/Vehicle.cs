using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Vehicle : Box
    {
        private bool isLeft;
        public Vehicle(int windowHeight, int windowWidth, int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image,bool isLeft)
            : base(windowHeight, windowWidth, boxHeight, boxWidth, posX, posY, speed, image)
        {
            this.isLeft = isLeft;
        }
        public override void moveUp()
        {
        }
        public override void moveDown()
        {
        }
        public override void moveLeft()
        {
            if (posX <= -100) posX=windowWidth+100;
            else posX -= speed;
        }
        public override void moveRight()
        {
            if (posX + speed >= windowWidth+100) posX = - 100;
            else posX += speed;
        }
        public override void move()
        {
            if (isLeft) moveLeft();
            else moveRight();
        }
        public static List<Box> createBox(int windowHeight, int windowWidth, int boxHeight, int boxWidth, int posX, int posY, int speed, Bitmap image, bool isLeft, int numOfBoxes,Random rand)
        {
            List<Box> list = new List<Box>();
            int pos = rand.Next(0,windowWidth);
            int offset = rand.Next(100, 200);
            int speeds = rand.Next(10,30);
            double num = rand.NextDouble();
            int size = 0;
            if (num > 0.5)
            {
                if (isLeft)
                    image = Properties.Resources.truckLeft;
                else image = Properties.Resources.truckRight;

                size = 120;
            }
            else
            {
                if (isLeft)
                    image = Properties.Resources.carLeft;
                else image = Properties.Resources.carRight;
                size = 60;
            }
                for (int i = 0; i < numOfBoxes; i++)
            {
                list.Add(new Vehicle(windowHeight, windowWidth, boxHeight, size, pos, posY, speeds, image, isLeft));
                pos += offset;
            }
            return list;
        }
    }
}
