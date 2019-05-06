using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create multiple nodes
            LinkedList ListItems = new LinkedList();
            ListItems.AddNextNode("B");
            ListItems.AddNextNode("E");
            ListItems.AddNextNode("E");
            ListItems.AddNextNode("B");
            ListItems.AddNextNode("A");
            ListItems.AddNextNode("B");
            //Display the nodes in list
            ListItems.displayNodes();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter the data for the root node");
            string rootNode = Console.ReadLine();
            ListItems.Addbeginning(rootNode);
            Console.WriteLine();
           
            ListItems.displayNodes();

            Console.WriteLine();
            Console.WriteLine("The expected remaining Nodes should be:");

            Console.WriteLine("E->B->E->B->A");

            Console.WriteLine("The actual remaining Nodes are:");
            ListItems.removeDups();
            ListItems.displayNodes();
            Console.Read();
        }
    }
}
