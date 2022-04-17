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
            for(int x = 0;x < g.Shape.GetLength(0);x++)//GetLength(0) is used to find the first dimension size
            {
                for(int y = 0;y < g.Shape.GetLength(1); y++)
                {
                    //GetLength(1) is used to find second dimension size
                    Boundry.boundry[g.StartingPoint.x+x, g.StartingPoint.y+y] = g.Shape[x, y];
                    Console.SetCursorPosition(g.StartingPoint.y + y, g.StartingPoint.x + x);
                    Console.Write(g.Shape[x, y]);
                }
            }
        }
        public static void EraseObject(GameObject g)
        {
            for (int x = 0; x < g.Shape.GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = g.Shape.GetLength(1); y >= 0; y--)
                {
                    //GetLength(1) is used to find second dimension size
                    Boundry.boundry[g.StartingPoint.x + x, g.StartingPoint.y + y] = ' ';
                    Console.SetCursorPosition(g.StartingPoint.y + y, g.StartingPoint.x + x);
                    Console.Write(' ');
                }
            }
        }
    }
}
