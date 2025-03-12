using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class SinglyNode <T>
    {
        public T Value { get; set; }
        public SinglyNode<T> Next { get; set; }
        public SinglyNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
