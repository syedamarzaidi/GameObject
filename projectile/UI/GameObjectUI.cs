using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using projectile.BL;
namespace projectile.UI
{
    class GameObjectUI
    {
        public static void draw(GameObject g)
        {
            for(int x = 0;x < g.getShape().GetLength(0);x++)//GetLength(0) is used to find the first dimension size
            {
                for(int y = 0;y < g.getShape().GetLength(1); y++)
                {
                    //GetLength(1) is used to find second dimension size
                    Point p = new Point(g.getStartingPoint().getX() + x, g.getStartingPoint().getY() + y);
                    Boundry.setBoundry(p , g.getShape()[x, y]);
                    Console.SetCursorPosition(g.getStartingPoint().getY() + y, g.getStartingPoint().getX() + x);
                    Console.Write(g.getShape()[x, y]);
                }
            }
        }
        public static void EraseObject(GameObject g)
        {
            for (int x = 0; x < g.getShape().GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = g.getShape().GetLength(1); y >= 0; y--)
                {
                    //GetLength(1) is used to find second dimension size
                    Point p = new Point(g.getStartingPoint().getX() + x, g.getStartingPoint().getY() + y);
                    Boundry.setBoundry(p, ' ');
                    Console.SetCursorPosition(g.getStartingPoint().getY() + y, g.getStartingPoint().getX() + x);
                    Console.Write(' ');
                }
            }
        }
    }
}
