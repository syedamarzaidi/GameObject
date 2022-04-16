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
        Point TopLeft;
        Point TopRight;
        Point BottomLeft;
        Point BottomRight;
    }
}
