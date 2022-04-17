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
            drawLine(b.TopLeft, b.TopRight, "HORIZONTAL", objectShape);
            drawLine(b.BottomLeft, b.BottomRight, "HORIZONTAL", objectShape);
            drawLine(b.TopLeft, b.BottomLeft, "VERTICAL", objectShape);
            drawLine(b.TopRight, b.BottomRight, "VERTICAL", objectShape);
        }
        public static void drawLine(Point startingPoint,Point endingPoint,string criteria,char objectShape)
        {
            if(criteria == "HORIZONTAL")
            {
                int x = startingPoint.x;
                for(int y = startingPoint.y; y < endingPoint.y; y++)
                {
                    Boundry.boundry[x, y] = objectShape;
                    Console.SetCursorPosition(y, x);
                    Console.Write(objectShape);
                }
            }
            else if(criteria == "VERTICAL")
            {
                int y = startingPoint.y;
                for(int x = startingPoint.x; x < endingPoint.y; x++)
                {
                    Boundry.boundry[x, y] = objectShape;
                    Console.SetCursorPosition(y, x);
                    Console.Write(objectShape);
                }
            }
        }
    }
}
