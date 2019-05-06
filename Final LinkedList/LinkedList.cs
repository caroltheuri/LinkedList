using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LinkedList
{
    public class LinkedList
    {
        //objects of class Node but have not been instatiated thefore we set them to null
        public Node headNode;
        public Node tempFirstNode;

        public LinkedList()
        {
            tempFirstNode = null;
            headNode = null;

        }
        public void  Addbeginning(string data)
        {
           
            if (headNode == null)
            {
                //int counts = 7;
                headNode = new Node(data);
                Node newhead = new Node(data);
                headNode.nextNode = tempFirstNode;
                tempFirstNode = headNode;
                //return counts;
            }
        }
       
        //using hash tables to remove duplicates
        public void removeDups()
        {
            Dictionary<string,int> dict = new Dictionary<string,int>();
            Node current = tempFirstNode;
            Node prev = null;
            while (current != null)
            {
                string currentvalue = current.data;
                if (dict.ContainsKey(currentvalue))
                {
                    int count = dict[currentvalue];
                    count++;

                    if (count > 2)
                    {
                       prev.nextNode = current.nextNode;
                    }
                    else
                    {
                        dict[currentvalue] = count;
                    }
                }
                else
                {
                    dict.Add(currentvalue,1);
                }
                prev = current;
                current = current.nextNode;
            }
        }
        public void AddNextNode(string data)
        {
            if (tempFirstNode == null)
            {
                tempFirstNode = new Node(data);
            }
            else
            {
                Node current = tempFirstNode;
                //Check for the last element before Adding a new node because last node has no node after it   
                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }
                //Create a new node if you have reached the last node
                current.nextNode = new Node(data);
            }
            
           
        }
        public void displayNodes()
        {
            int count = 1;
            Node current = tempFirstNode;
            while (current.nextNode != null)
            {
                count += 1;
                current = current.nextNode;
            }
            Console.WriteLine($"The number of nodes that exist in the linked list are {count}");
            if (tempFirstNode != null)
            {
                tempFirstNode.displayNodes();
            }
        }
    }
}
