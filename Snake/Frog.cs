using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Frog : Creature
    {
        private Point position;
        private bool alive;

        public Frog(String fileName, Grid grid)
        :base(fileName,grid)
        { 
        
        }
        public void Draw()
        {
            GetGridCellForPosition(position).Value = head;
        }
    
    }
}
