using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.delete_node
{
    internal class Node
    {
        public int data;
        public Node Next;

        public Node(int data)
        {
            this.data = data;
            this.Next = null;
        }
    }
}
