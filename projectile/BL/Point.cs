using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectile.BL
{
    class Point
    {
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        private int x;
        private int y;
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
