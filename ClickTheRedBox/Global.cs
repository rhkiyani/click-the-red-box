using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClickTheRedBox
{
    public class Global
    {
        string _lastRedButton;
        int _score;

        public Global()
        {
            _lastRedButton = "";
            _score = 0;
        }

        public void updateScore()
        {
            _score++;
        }

        public int getScore()
        {
            return _score;
        }

        public void updateLastRedButton(string b)
        {
            _lastRedButton = b;
        }

        public string getLastRedButton()
        {
            return _lastRedButton;
        }
    }
}