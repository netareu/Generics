using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ReverseBlock:IBlock<string>
    {
        public string Process(string input)
        {
            if (input == null)
            {
                return input;
            }
            
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
