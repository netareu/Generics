using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Block<T>:IBlock<T> where T : class
    {
        public T Process(T input)
        {
            return input;
        }
    }
}
