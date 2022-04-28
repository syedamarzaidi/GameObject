using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectile.BL
{
    class Boundry
    {
        public Boundry()
        {
            this.TopLeft.setXY(0, 0);
            this.TopRight.setXY(0, 90);
            this.BottomLeft.setXY(90, 0);
            this.BottomRight.setXY(90, 90);
        }
        public Boundry(Point TopLeft,Point TopRight,Point BottomLeft,Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
        private Point TopLeft;
        private Point TopRight;
        private Point BottomLeft;
        private Point BottomRight;
       private static char[,] boundry = new char[200,200];
        public static char getBoundryCharacter(Point p)
        {
            return boundry[p.getX(), p.getY()];
        }
        public static char[,] getBoudry()
        {
            return boundry;
        }
        public static void setBoundry(Point location, char shape)
        {
           boundry[location.getX(), location.getY()] = shape;
        }
        public Point getTopLeft()
        {
            return TopLeft;
        }
        public Point getTopRight()
        {
            return TopRight;
        }
        public Point getBottomLeft()
        {
            return BottomLeft;
        }
        public Point getBottomRight()
        {
            return BottomRight;
        }
        private char[,] getBoundry()
        {
            return boundry;
        }
    }
}
