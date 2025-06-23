using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IBlock<T> where T : class
    {
        T Process(T input);
    }
}
