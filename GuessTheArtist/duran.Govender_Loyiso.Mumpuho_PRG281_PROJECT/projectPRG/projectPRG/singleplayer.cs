using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPRG
{
    class singleplayer
    {
        private string player1;
        private int score1;

        public singleplayer(string player1, int score1)
        {
            this.player1 = player1;
            this.score1 = score1;
        }

        public int Scor1e { get => score1; set => score1 = value; }
        public string Player1 { get => player1; set => player1 = value; }

    }
}
