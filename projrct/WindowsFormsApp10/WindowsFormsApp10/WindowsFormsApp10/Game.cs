using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
   
    class Game
    {
        public Game() {  }
        
        private int score;
        private int level;
        private int duration;
        
        public int Score { get => score; set => score = value; }
        public int Level { get => level; set => level = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
