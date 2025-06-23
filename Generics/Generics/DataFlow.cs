using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataFlow<T>:IDataFlow<T> where T : class
    {
        public LinkedList<IBlock<T>> DataBlocksFlow = new LinkedList<IBlock<T>>();
        private LinkedListNode<IBlock<T>> _currentNode;
        public T RunFlow(T input)
        {
            if (DataBlocksFlow == null || DataBlocksFlow.Count == 0)
            {
                return input;
            }

            _currentNode = DataBlocksFlow.First;
            T output = _currentNode.Value.Process(input);

            foreach (IBlock<T> block in DataBlocksFlow)
            {
                _currentNode = _currentNode.Next;
                output = block.Process(output);
            }
            return output;
        }
        public void AddBlock(IBlock<T> block)
        {
            if (block == null)
            {
                return;
            }
            DataBlocksFlow.AddLast(block);
        }
    }
}
