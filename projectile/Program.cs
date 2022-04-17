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
            char[,] shape = new char[,] { { ' ', ' ', '#' ,' ',' '},
                { ' ', '#', '#','#',' ' },
                { '#', '#', ' ','#','#' },
            { ' ','#',' ','#',' '}, {'#',' ',' ',' ','#'} };
            Boundry b = new Boundry(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject g1 = new GameObject(shape, new Point(15, 45), b,"LeftToRight");
            BoundryUI.drawBoundry('-', b);
            GameObjectUI.draw(g1);

            while (true)
            {
                GameObject.move(g1);
                Thread.Sleep(100);
            }
        }
    }
}
