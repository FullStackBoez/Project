using System;
using System.Collections.Generic;
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
            createLanes();
        }

        public void updateGrid()
        {
            List<Lane> tmp = new List<Lane>();
            for(int i = 1; i < lanes.Count; i++)
            {
                tmp.Add(lanes[i]);
                tmp[i-1].Y += boxHeight;
                if (tmp[i - 1].powerup != null) tmp[i - 1].powerup.Y += boxHeight;
                if (tmp[i - 1].rock != null) tmp[i - 1].rock.Y += boxHeight;
                if (tmp[i - 1].Type != 0)
                {
                    foreach (Box b in tmp[i - 1].lineBox)
                    {
                        b.Y += boxHeight;
                    }
                }
            }
            lanes[0].Dispose();
            tmp.Add(new Lane(0, 0, boxHeight, windowWidth, rand, windowHeight, windowWidth));
            lanes = tmp;
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
