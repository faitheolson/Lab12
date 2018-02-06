using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RockPlayer:Player
    {
        string Name { set; get; }
        string RoshamboValue { set; get; }
        //constructors
        public RockPlayer(string name)
        {
            Name = name;
            //RoshamboValue = R;
        }

        public override string GenerateRoshambo()
        {
            RoshamboValue = "Rock";
            return RoshamboValue;
        }

    }
}
