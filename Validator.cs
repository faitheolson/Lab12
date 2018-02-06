using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12
{
    static class Validator
    {
        //validate opponent input
        static public int OpponentInput(string Input)
        {
            while (!Regex.Match(Input, @"^(1|2)$").Success)
            {
                Console.Clear();
                Console.WriteLine("Please select a valid opponent:\nPick... [1]AI or [2]Rock:");
                Input = Console.ReadLine();
            }
            int NewInput = int.Parse(Input);
            return NewInput;

        }
        static public int RPS(string Input)
        {
            while (!Regex.Match(Input, @"^(1|2|3)$").Success)
            {
                Console.Clear();
                Console.WriteLine("Please enter a vaild selection\nPick... [1]Rock, [2]Paper or [3]Scissors:");
                Input = Console.ReadLine();
            }
            int NewInput = int.Parse(Input);
            return NewInput;
        } 


        //validate RPS input

    }
}
