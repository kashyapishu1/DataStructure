using LinkListPrograms;

public class Program
{
    public static void Main(string[] args)
    {
        bool breakThis = false;
        while(!breakThis)
        {
           
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Press 1 for the Link List");
            Console.WriteLine("Enter youe choice:- ");
            int parentchoice = Convert.ToInt32(Console.ReadLine());
            
            switch(parentchoice)
            {
                case 0:
                    {
                        breakThis = true;
                        break;
                    }
                case 1:
                    {
                        new LinkListHandler();
                        break;
                    }
            }
        }
    }
}