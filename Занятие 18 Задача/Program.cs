using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_18_Задача
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsWellFormedBrackets(string input)
            {
                string previous = "";
                while (input.Length != previous.Length)
                {
                    previous = input;
                    input = input
                        .Replace("()", String.Empty)
                        .Replace("[]", String.Empty)
                        .Replace("{}", String.Empty);
                }
                return (input.Length == 0);
            }
        }
    }
}
