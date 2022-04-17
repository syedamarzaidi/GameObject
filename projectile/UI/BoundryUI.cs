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
        public static void drawBoundry(char objectShape,Boundry objectBoundry)
        {
            drawLine(objectBoundry.TopLeft.x, objectBoundry.TopRight.y,"HORIZONTAL",objectShape);
            drawLine(objectBoundry.TopLeft.x, objectBoundry.BottomLeft.x,"VERTICAL", objectShape);
        }
        public static void drawLine(int start,int end,string direction,char objectShape)
        {
            if(direction == "HORIZONTAL")
            {
                for(int y = start; y <= end; y++)
                {
                    Boundry.boundry[start,y]= objectShape;
                    Console.SetCursorPosition(y, start);
                    Console.Write(objectShape);
                }
            }
            else if(direction == "VERTICAL")
            {
                for(int x = start; x <= end; x++)
                {
                    Boundry.boundry[x, start] = objectShape;
                    Console.SetCursorPosition(start, x);
                    Console.Write(objectShape);
                }
            }
        }
    }
}
