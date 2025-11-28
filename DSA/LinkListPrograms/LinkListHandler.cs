using System;
using System.Runtime.InteropServices.Marshalling;
namespace LinkListPrograms
{
    public class LinkListHandler
    {
        public LinkListHandler()
        {
            LinkListOpertions llo = new LinkListOpertions();
            bool breakThis = false;
            while (!breakThis)
            {
                Console.WriteLine("Press 0 to break");
                Console.WriteLine("Press 1 to Display List");
                Console.WriteLine("Press 2 to add a node in list");
                Console.WriteLine("Press 3 to add a multiple node in list");
                Console.WriteLine("Press 4 to Find the total number of elements");
                Console.WriteLine("Press 5 to find the postion of a value");
                Console.WriteLine("Press 6 to find the value in Last node");
                int parentchoice = Convert.ToInt32(Console.ReadLine());
                switch (parentchoice)
                {
                    case 0:
                        {
                            breakThis = true;
                            break;
                        }
                    case 1:
                        {
                            llo.DisplayList();
                            break;
                        }
                    case 2:
                        {
                            llo.InsertNewNodeToList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the total number of element.");
                            int count = Convert.ToInt32(Console.ReadLine());
                            for(int i=0;i<count;i++)
                            {
                                llo.InsertNewNodeToList();
                            }
                            
                            break;
                        }
                    case 4:
                        {
                            llo.CountNumberOfNode();
                            break;
                        }
                    case 5:
                        {
                            llo.Search();
                            break;
                        }
                    case 6:
                        {
                            llo.FindLast();
                            break;
                        }
                }

            }
        }
    }
}
