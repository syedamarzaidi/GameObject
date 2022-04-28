using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectile.DL;
using projectile.UI;
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
        private char[,] Shape = new char[20, 20];
        private Point StartingPoint;
        private Boundry Premises;
        private string Direction;
        private string patrolingFlag = "LEFT";
        private int projectileCount = 0;//This attribute is used to take decisions that how many times object is moved at certain direction and it is now time to change this count 
        public char[,] getShape()
        {
            return Shape;
        }
        public Point getStartingPoint()
        {
            return StartingPoint;
        }
        public Boundry getPremises()
        {
            return Premises;
        }
        public string getDirection()
        {
            return Direction;
        }
        public string getPatrolingFlag()
        {
            return patrolingFlag;
        }
        public int getProjectileCount()
        {
            return projectileCount;
        }
        public void setProjectileCount(int projectileCount)
        {
            this.projectileCount = projectileCount;
        }
        public void setStartingPoint(int x,int y)
        {
            this.StartingPoint.setXY(x, y);
        }
        public void setPatrolingFlag(string patrolingFlag)
        {
            this.patrolingFlag = patrolingFlag;
        }
        public static void move(GameObject g)
        {
            if(g.Direction== "LeftToRight")
            {
                GameObjectDL.MoveLeftToRight(g, 1, '-');
            }
            else if(g.Direction == "RightToLeft")
            {
                GameObjectDL.MoveLeftToRight(g, 1, '-');
            }
            else if(g.Direction == "projectile")
            {
                GameObjectDL.moveProjectile(g, 1, '-');
            }
            else if(g.Direction == "patrol")
            {
                GameObjectDL.patrol(g, 1, '-');
            }
            else if(g.Direction == "Dagnol")
            {
                GameObjectDL.moveDiagnol(g, 1, '-', "BottomRight");
            }
        }
        public static bool isMoveRightPossible(GameObject g,char obstacle)
        {
            for (int x = 0; x < g.Shape.GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = g.Shape.GetLength(1); y >= 0; y--)
                {
                    Point p = new Point(g.StartingPoint.getX() + x, g.StartingPoint.getY() + y + 1);
                    if(Boundry.getBoundryCharacter(p) == obstacle)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool isMoveLeftPossible(GameObject g,char obstacle)
        {
            for (int x = 0; x < g.Shape.GetLength(0); x++)//GetLength(0) is used to find the first dimension size
            {
                for (int y = 0; y < g.Shape.GetLength(1); y++)
                {
                    Point p = new Point(g.StartingPoint.getX() + x, g.StartingPoint.getY() - 1);
                        if (Boundry.getBoundryCharacter(p) == obstacle)
                        {
                            return false;
                        }
                }
            }
            return true;
        }
        public static bool isMoveUpPossible(GameObject g,char obstacle)
        {
            Point p = new Point(g.StartingPoint.getX() - 1, g.StartingPoint.getY());
            if(Boundry.getBoundryCharacter(p) == obstacle)
            {
                return false;
            }
            return true;
        }
        public static bool isMoveDownPossible(GameObject g,char obstacle)
        {
            Point p = new Point(g.StartingPoint.getX() + g.Shape.GetLength(0), g.StartingPoint.getY());
            if (Boundry.getBoundryCharacter(p) == obstacle)
            {
                return false;
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
