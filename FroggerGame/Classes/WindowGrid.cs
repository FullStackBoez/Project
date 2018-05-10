using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class WindowGrid
    {
        // This class sets the grid of the main window witch makes it easier to draw the gaming components (frog , cars, logs etc)
        private static Random rand;
        private int windowHeight;
        private int windowWidth;
        private int boxHeight;
        private int boxWidth;
        public static List<Rock> rockList;
        private List<Lane> lanes;
        public static int cameraSpeed;
        private bool flag = false;

        public List<Lane> windowLanes { get { return lanes; } }

        public WindowGrid(int windowHeight, int windowWidth, int boxHeight, int boxWidth)
        {
            this.windowHeight = windowHeight;
            this.windowWidth = windowWidth;
            this.boxHeight = boxHeight;
            this.boxWidth = boxWidth;
            this.lanes = new List<Lane>();
            rockList = new List<Rock>();
            rand = new Random();
            cameraSpeed = 1;
            createLanes();
        }

        public void updateGrid()
          {
            List<Lane> tmp = new List<Lane>();


            for (int i = 0; i < lanes.Count; i++)
              {
                  tmp.Add(lanes[i]);
                  tmp[i].Y += cameraSpeed;
                  if (tmp[i].powerup != null) tmp[i].powerup.Y += cameraSpeed;
                  if (tmp[i ].rock != null) tmp[i].rock.Y += cameraSpeed;
                  if (tmp[i ].Type != 0)
                  {
                      foreach (Box b in tmp[i ].lineBox)
                      {
                          b.Y += cameraSpeed;
                      }
                  }
              }
            if (lanes.Count < 16)
                tmp.Add(new Lane(0, -(boxHeight-cameraSpeed), boxHeight, windowWidth, rand, windowHeight, windowWidth));
            if (tmp[0].Y>=600)
            {
                tmp[0] = null;
                lanes[0].Dispose();
            }
              flag=!flag;
            lanes = new List<Lane>();
            foreach (Lane b in tmp)
            {
                if(b!=null)
                lanes.Add(b);
            }
        }
        private void createLanes()
        {
            int tmp = windowHeight;
            tmp = tmp - boxHeight;
            lanes.Add(new Lane(0, tmp, boxHeight, windowWidth, windowHeight, windowWidth));
            tmp = tmp - boxHeight;
            while (tmp >= 0)
            {
                lanes.Add(new Lane(0,tmp,boxHeight,windowWidth,rand, windowHeight,windowWidth));
                tmp = tmp - boxHeight;
            }
        }
        public bool crashed(Frog frog)
        {
            if (frog.isInvincible) return false;
            foreach (Lane l in lanes)
            {
                if (l.Y == frog.Y && l.Type == 0) return false;
                if (l.Y == frog.Y && l.Type == 1)
                    foreach (Box b in l.lineBox)
                    {
                        if (frog.crash(b))
                        {
                           frog.takeALife();
                            if(frog.dead)
                            return true;
                            else return false;
                        }
                    }
                if (l.Y == frog.Y && l.Type == 2)
                {
                    foreach (Box b in l.lineBox)
                    {
                        if (frog.onLog(b))
                        {
                            frog.attach((Log)b);
                            frog.move();
                            return false;
                        }
                    }
                    frog.takeALife();
                    if (frog.dead)
                        return true;
                    else return false;
                }
            }
            return false;
        }
    }
}
