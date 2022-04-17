using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectile.BL;

namespace projectile.DL
{
    class GameObjectDL
    {
        public static void MoveOneStepRight(char objectShape,int steps,Boundry gameBoundry,GameObject g) 
        {
          for(int x = gameBoundry.BottomRight.x;x > 0; x--)
            {
                for(int y =gameBoundry.TopRight.y; y > 0; y--)
                {
                    //if()
                }
            }
        }
    }
}
