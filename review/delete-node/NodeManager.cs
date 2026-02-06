using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//delete nodes without using head reference
namespace review.delete_node
{
    internal class NodeManager
    {
        Node head;
        public void Add(Node newNode)
        {

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        public void DeleteNode(int deleteValue, Node[] nodes)
        {
            Node temp = nodes[0];

            if (temp.data == deleteValue)
            {
                head = head.Next;
                return;
            }

            Node prev = temp;
            Node curr = temp.Next;
            while (curr.data != deleteValue)
            {
                prev = prev.Next;
                curr = curr.Next;
            }

            prev.Next = curr.Next;

        }

        public void Display()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.Next;
            }
        }

        public static void Main(string[] args)
        {
            NodeManager list = new NodeManager();

            Console.Write("Enter Number Of Nodes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Node[] nodes = new Node[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Number: ");
                Node newNode = new Node(Convert.ToInt32(Console.ReadLine()));
                list.Add(newNode);
                nodes[i] = newNode;

            }

            list.Display();

            Console.Write("\nEnter Data to be Deleted: ");
            int delete = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNode Deleted");

            list.DeleteNode(delete, nodes);

            list.Display();



        }
    }
}
