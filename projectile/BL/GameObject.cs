using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectile.BL
{
    class GameObject
    {
        public GameObject()
        {
            this.Shape = new char[,] { { '-', '-', '-' }};
            this.StartingPoint.setXY(0, 0);
            this.Premises = new Boundry();
            this.Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape,Point StartingPoint,Boundry Premises,string Direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }
        public char[,] Shape = new char[20, 20];
        Point StartingPoint;
        Boundry Premises;
        string Direction;
    }
}
