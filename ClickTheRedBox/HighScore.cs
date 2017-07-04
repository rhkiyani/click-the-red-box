using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClickTheRedBox
{
    public class HighScore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public HighScore(string initial, int score)
        {
            Name = initial;
            Score = score;
        }
        public HighScore()
        {
            Name = "";
            Score = 0;
        }
    }
}