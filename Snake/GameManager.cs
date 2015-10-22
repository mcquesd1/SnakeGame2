using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakeGame
{
    public class GameManager
    {
        private Grid grid;
        private Random random;
        private Snake snake;

        public GameManager(Grid grid, Random random)
        {
            this.grid = grid;
            this.random = random;
            snake = new Snake("snakeEyes.bmp", "snakeSkin.bmp", grid);
        }

        public void StartNewGame()
        {
            grid.Draw();
            snake.Draw();

        }
        
        public ErrorMessage PlayGame()
        {
            grid.Draw();
            snake.Draw();
            snake.Move();

            ErrorMessage message = ErrorMessage.noError;

            if (snake.HitWall() == true)
            {
                message = ErrorMessage.snakeHitWall;
            }

            return message; 
        }

        private Point FindFreeCell()
        {
            Point target = Point.Empty;

            while (target == Point.Empty)
            {
                int i = random.Next(30);
                int j = random.Next(30);

                if (grid.Rows[i].Cells[j].Value == grid.Blank)
                {
                    target = new Point(i, j);
                }
            }

            return target;
        }

        public void SetSnakeDirection(Direction direction)
        {
            //snake.Direction = direction;
        }
  }
}
