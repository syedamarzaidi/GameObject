using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using projectile.UI;
using projectile.BL;
namespace projectile
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[,] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' } };
            Boundry b = new Boundry(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject g1 = new GameObject(triangle, new Point(15, 45), b,"LeftToRight");
            BoundryUI.drawBoundry('-', b);
            GameObjectUI.draw(g1);
            while (true)
            {
                // GameObjectUI.EraseObject(g1);
                /*if (GameObject.isMoveRightPossible(g1))
                {
                    GameObjectUI.MoveLeftToRight(g1, 1);
                }*/
                if (GameObject.isMoveLeftPossible(g1))
                {
                    GameObjectUI.MoveRightToLeft(g1, 1);
                }
                Thread.Sleep(100);
            }
        }
    }
}
