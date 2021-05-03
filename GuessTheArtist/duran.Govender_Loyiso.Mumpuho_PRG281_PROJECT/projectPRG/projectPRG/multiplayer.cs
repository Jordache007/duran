using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPRG
{
    class multiplayer : singleplayer
    {

        private string player2;

        private int score2;

        public multiplayer(string player1, string player2, int score1, int score2) : base(player1, score1)
        {

            this.player2 = player2;

            this.Score2 = score2;
        }


        public string Player2 { get => player2; set => player2 = value; }

        public int Score2 { get => score2; set => score2 = value; }
        public override string ToString()
        {
            return string.Format("{0},{1}", Score2, score2);
        }
    }
}
