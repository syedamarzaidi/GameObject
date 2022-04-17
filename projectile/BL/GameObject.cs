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
        public GameObject(char[,] Shape , Point StartingPoint)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = new Boundry();
            this.Direction = "LeftToRight";
        }
        public char[,] Shape = new char[20, 20];
        public Point StartingPoint;
        public Boundry Premises;
        public string Direction;
        public void setStartingPoint(int x,int y)
        {
            this.StartingPoint.setXY(x, y);
        }
        public static bool isMoveRightPossible(GameObject g)
        {
            for (int x = 0; x < g.Shape.GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = g.Shape.GetLength(1); y >= 0; y--)
                {
                    if(Boundry.boundry[g.StartingPoint.x + x, g.StartingPoint.y + y + 1] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool isMoveLeftPossible(GameObject g)
        {
            for (int x = 0; x < g.Shape.GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = 0; y < g.Shape.GetLength(1); y++)
                {
                    if (Boundry.boundry[g.StartingPoint.x + x, g.StartingPoint.y + y - 1] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    
   /* public static void Move(string Direction)
    {
        if(Direction == "LeftToRight")
        {
            MoveLeft('@',1);
        }
    }*/
}
