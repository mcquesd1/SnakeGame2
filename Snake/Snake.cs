using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakeGame
{
    public class Snake: Creature
    {
        private const int SNAKESTART = 15;
        private const int LENGTH = 8;
        private const int NCELLS = 30;

        private Bitmap body;
        private Point[] position; 
        private int length;
        private Direction direction;

        public Snake(String fileName, String fileName2, Grid grid)
            : base(fileName, grid)
        {
            body = new Bitmap(fileName2);
            direction = Direction.Right;
            length = LENGTH;

            position = new Point[100];
            for (int i = 0; i < length; i++)
            {
                position[i] = new Point(SNAKESTART - i, SNAKESTART);
            }
        }

        public override void Draw()
        {
            GetGridCellForPosition(position[0]).Value = head;

            for (int i = 1; i < length; i++)
            {
                GetGridCellForPosition(position[i]).Value = body;
            }
        }

        public void Move()
        {
            for (int i = (length - 1); i > 0; i--)
            {
               position[i] = position[i-1]; 
            }

            switch (direction)
            {
                case Direction.Up:
                    break;
                case Direction.Down:
                    break;
                case Direction.Left:
                    break;
                case Direction.Right:
                    position[0].X ++;
                    break;
                default:
                    break;
            }

      
        }

        public bool HitWall()
        {
            bool hit = false;
            
            if ((position[0].X < 0) || (position[0].X > (NCELLS - 1)) 
                || (position[0].Y < 0) || (position[0].Y > (NCELLS - 1)))
            {
               hit = true; 
            }

            return hit;
        }
    }
}
