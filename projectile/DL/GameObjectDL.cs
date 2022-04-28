using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectile.BL;
using projectile.UI;
namespace projectile.DL
{
    class GameObjectDL
    {
        public static void MoveLeftToRight(GameObject g, int step, char obstacle)
        {
            for (int i = 0; i < step; i++)
            {
                if (GameObject.isMoveRightPossible(g, obstacle))
                {
                    GameObjectUI.EraseObject(g);
                    for (int x = 0; x < g.getShape().GetLength(0); x++)//GetLength(0) is used to find the first dimension size
                    {
                        for (int y = 0; y < g.getShape().GetLength(1); y++)
                        {
                            Point p = new Point(g.getStartingPoint().getX() + x, g.getStartingPoint().getY() + y + step);
                            Boundry.setBoundry(p , g.getShape()[x, y]);
                            Console.SetCursorPosition(g.getStartingPoint().getY() + y + step, g.getStartingPoint().getX() + x);
                            Console.Write(g.getShape()[x, y]);
                        }
                    }
                    g.setStartingPoint(g.getStartingPoint().getX(), g.getStartingPoint().getY() + step);//+1
                }
            }
        }
        public static void MoveRightToLeft(GameObject g, int step, char obstacle)
        {
            for (int i = 0; i < step; i++)
            {
                if (GameObject.isMoveLeftPossible(g, obstacle))
                {
                    GameObjectUI.EraseObject(g);
                    for (int x = 0; x < g.getShape().GetLength(0); x++)//GetLength(0) is used to find the first dimension size
                    {
                        for (int y = 0; y < g.getShape().GetLength(1); y++)
                        {
                            Point p = new Point(g.getStartingPoint().getX() + x, g.getStartingPoint().getY() + y - step);
                            Boundry.setBoundry(p , g.getShape()[x, y]);
                            Console.SetCursorPosition(g.getStartingPoint().getY() + y - step, g.getStartingPoint().getX() + x);
                            Console.Write(g.getShape()[x, y]);
                        }
                    }
                    g.setStartingPoint(g.getStartingPoint().getX(), g.getStartingPoint().getY() - step);
                }
            }
        }
        public static void MoveUp(GameObject g, int step, char obstacle)
        {
            if (GameObject.isMoveUpPossible(g, obstacle))
            {
                GameObjectUI.EraseObject(g);
                for (int x = 0; x < g.getShape().GetLength(0); x++)//GetLength(0) is used to find the first dimension size
                {
                    for (int y = 0; y < g.getShape().GetLength(1); y++)
                    {
                        Point p = new Point(g.getStartingPoint().getX() + x - step, g.getStartingPoint().getY() + y);
                        Boundry.setBoundry(p , g.getShape()[x, y]);
                        Console.SetCursorPosition(g.getStartingPoint().getY() + y, g.getStartingPoint().getX() + x - step);
                        Console.Write(g.getShape()[x, y]);
                    }
                }
                g.setStartingPoint(g.getStartingPoint().getX() - step, g.getStartingPoint().getY());
            }
        }
        public static void MoveDown(GameObject g, int step, char obstacle)
        {
            if (GameObject.isMoveDownPossible(g, obstacle))
            {
                GameObjectUI.EraseObject(g);
                for (int x = g.getShape().GetLength(0) - 1; x >= 0; x--)
                {
                    for (int y = 0; y < g.getShape().GetLength(1); y++)
                    {
                        Point p = new Point(g.getStartingPoint().getX() + x + step, g.getStartingPoint().getY() + y);
                        Boundry.setBoundry(p , g.getShape()[x, y]);
                        Console.SetCursorPosition(g.getStartingPoint().getY() + y, g.getStartingPoint().getX() + x + step);
                        Console.Write(g.getShape()[x, y]);
                    }
                }
                g.setStartingPoint(g.getStartingPoint().getX() + step, g.getStartingPoint().getY());
            }
        }
        public static void patrol(GameObject g, int step, char obstacle)
        {
            if (g.getPatrolingFlag() == "LEFT")
            {
                MoveRightToLeft(g, step, obstacle);
                if (!GameObject.isMoveLeftPossible(g, obstacle)) {
                    g.setPatrolingFlag("RIGHT");
                }
            }
            else if (g.getPatrolingFlag() == "RIGHT")
            {
                MoveLeftToRight(g, step, obstacle);
                if (!GameObject.isMoveRightPossible(g, obstacle))
                {
                    g.setPatrolingFlag("LEFT");
                }
            }
        }
        public static void moveProjectile(GameObject g, int step, char obstacle)
        {
            if (g.getProjectileCount() < 5)
            {
                moveDiagnol(g, step, obstacle,"TopRight");
            }
            else if (g.getProjectileCount() < 7)
            {
                MoveLeftToRight(g, step, obstacle);
            }
            else if(g.getProjectileCount() < 11)
            {
                moveDiagnol(g, step, obstacle, "BottomRight");
            }
            int count = g.getProjectileCount() + 1;
            g.setProjectileCount(count);
        }
        public static void moveDiagnol(GameObject g, int step, char obstacle, string Direction)
        {
            if (Direction == "TopRight")
            {
                MoveUp(g, step, obstacle);
                MoveLeftToRight(g, step, obstacle);
            }
            else if (Direction == "BottomRight")
            {
                MoveDown(g, step, obstacle);
                MoveLeftToRight(g, step, obstacle);
            }
            else if(Direction == "BottomLeft")
            {
                MoveDown(g, step, obstacle);
                MoveRightToLeft(g, step, obstacle);
            }
            else if(Direction == "TopLeft"){
                MoveUp(g, step, obstacle);
                MoveRightToLeft(g, step, obstacle);
            }
        }
   }
}
