using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class AIPlayer:Player
    {
        string Name { set; get; }
        string RoshamboValue { set; get; }
        //constructors
        public AIPlayer(string name)
        {
            Name = name;
            //RoshamboValue = R;
        }

        public override string GenerateRoshambo()
        {
            int Choice = new Random().Next(1, 3);
            if (Choice == 1)
            {
                RoshamboValue = "Rock";
            }
            else if (Choice == 2)
            {
                RoshamboValue = "Paper";
            }
            else
            {
                RoshamboValue = "Scissors";
            }
            return RoshamboValue;
        }
    }
}
