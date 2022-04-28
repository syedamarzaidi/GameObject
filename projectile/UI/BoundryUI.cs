using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectile.BL;

namespace projectile.UI
{
    class BoundryUI
    {
       public static void drawBoundry(char objectShape,Boundry b)
        {
            drawLine(b.getTopLeft(), b.getTopRight(), "HORIZONTAL", objectShape);
            drawLine(b.getBottomLeft(), b.getBottomRight(), "HORIZONTAL", objectShape);
            drawLine(b.getTopLeft(), b.getBottomLeft(), "VERTICAL", objectShape);
            drawLine(b.getTopRight(), b.getBottomRight(), "VERTICAL", objectShape);
        }
        public static void drawLine(Point startingPoint,Point endingPoint,string criteria,char objectShape)
        {
            if(criteria == "HORIZONTAL")
            {
                int x = startingPoint.getX();
                for(int y = startingPoint.getY(); y < endingPoint.getY(); y++)
                {
                    Point p = new Point(x, y);
                    Boundry.setBoundry(p , objectShape);
                    Console.SetCursorPosition(y, x);
                    Console.Write(objectShape);
                }
            }
            else if(criteria == "VERTICAL")
            {
                int y = startingPoint.getY();
                for(int x = startingPoint.getX(); x < endingPoint.getX(); x++)
                {
                    Point p = new Point(x, y);
                    Boundry.setBoundry(p , objectShape);
                    Console.SetCursorPosition(y, x);
                    Console.Write(objectShape);
                }
            }
        }
    }
}