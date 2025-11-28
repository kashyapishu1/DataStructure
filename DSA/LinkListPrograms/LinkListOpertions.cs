using DSA.LinkList;
using System;
using System.ComponentModel;
namespace LinkListPrograms
{
    public class LinkListOpertions
    {
        public Node start;

        public LinkListOpertions()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            p = start;
            while (p != null)
            {
                Console.Write(p.info + "    ");
                p = p.link;
            }
            Console.WriteLine();

        }

        public void InsertNewNodeToList()
        {
            var value = Convert.ToInt32(Console.ReadLine());
            if (start == null)
            {
                start = new Node(value);
                return;
            }
            Node p = start;
            while (p.link != null)
            {
                p = p.link;

            }

            if (p.link == null)
            {
                p.link = new Node(value);
            }

        }

        public void CountNumberOfNode()
        {
            if (start == null)
            {
                Console.WriteLine("Count is " + 0);
                return;
            }
            int counter = 0;
            Node p = start;
            while (p != null)
            {
                p = p.link;
                counter += 1;
            }

            Console.WriteLine("Count is " + counter);
        }

        public void Search()
        {

            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("Enter ther value to search");
            var value = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            Node p = start;
            bool found = false;
            while (p != null)
            {
                counter += 1;
                if (p.info == value)
                {
                    found = true;
                    break;
                }
                p = p.link;

            }
            if (found)
                Console.WriteLine("Value found at Node " + counter);
            else
                Console.WriteLine("Not Found");
        }

        public void FindLast()
        {
            if(start ==null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node p = start;
            while (p != null)
            {
                if(p.link==null)
                {
                    Console.WriteLine("The value in last node is "+p.info);
                }
                p = p.link;
            }
        }

    }
}

