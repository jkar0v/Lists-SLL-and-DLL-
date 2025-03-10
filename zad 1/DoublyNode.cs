using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists__SLL_and_DLL_
{
    class DoublyNode <T>
    {
        internal T Data { get; set; }
        internal DoublyNode<T> Previous { get; set; }
        internal DoublyNode<T> Next { get; set; }
        internal DoublyNode(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }
    }
}
