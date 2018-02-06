using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer:Player
    {
        string Name { set; get; }
        string RoshamboValue { set; get; }
        //constructors
        public HumanPlayer(string name)
        {
            Name = name;
            //RoshamboValue = R;
        }
        public override string GenerateRoshambo()
        {
            Console.WriteLine("Pick... [1]Rock, [2]Paper or [3]Scissors:");
            int Choice = Validator.RPS(Console.ReadLine());
           

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
