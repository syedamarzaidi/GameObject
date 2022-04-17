using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectile.UI;
using projectile.BL;
namespace projectile
{
    class Program
    {
        static void Main(string[] args)
        {
            Boundry b = new Boundry();
            BoundryUI.drawBoundry('@',b);
            Console.ReadKey();
        }
    }
}
