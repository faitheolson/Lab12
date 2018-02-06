using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        string Name { set; get; }
        string RoshamboValue {set; get;}

       


        //Method called generateRoshambo

        public abstract string GenerateRoshambo();
    }
}
