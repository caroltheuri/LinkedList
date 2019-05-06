using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LinkedList
{
    public class Node
    {
        public string data;
        public Node nextNode;

        //constructor that allows assigning of values to the class properties when accessed
        public Node(string data)
        {
            this.data = data;
            nextNode = null;
        }
        //Method that displays nodes in the list. Its just for visual purposes 
        public void displayNodes()
        {
            Console.Write($"{data}->");
            if (nextNode != null)
            {
                nextNode.displayNodes();
            }
        }
        
    }
}
