using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
       // GreetContent newCustomer = new GreetContent();
        GreetRepository _greetRepo = new GreetRepository();
        List<GreetContent> customers; 
        public void Run()
        {
           customers = _greetRepo.GetGreetContentList();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine(".1 Create Badge\n" +
                   ".2 Delete Badge\n" +
                   ".3 See badge\n" +
                   ".4 Update Door\n" +
                   ".5 Exit ");
                int newInput = int.Parse(Console.ReadLine());

                switch (newInput)
                {
                    case 1:
                        CreateBadge();
                        break;
                    case 2:
                       Delete();
                        break;
                    case 3:
                       // PrintDoors();
                        break;
                    case 4:
                       // UpdateDoor();
                        break;
                    case 5:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
       
        private void Delete()
        {
            Console.WriteLine("Customers:");
            foreach (GreetContent content in customers)
            {
                Console.WriteLine(content.CustomerFirstName);
            }
            Console.WriteLine();
            Console.WriteLine("Enter customer that do you want to remove?");
            var removecustomer = Console.ReadLine();
            foreach (GreetContent content in customers)
            {
                if (removecustomer == content.CustomerFirstName)
                {
                    _greetRepo.RemoveGreetContent(content);
                    break;
                }
                
            }


        }

    

        private void CreateBadge()
        {
            Console.Clear();
            List<string> customer = new List<string>();
            Console.Write("Enter First Name:");
             var customerFirstName = Console.ReadLine();
            Console.Write("Enter Last Name:");
            var customerLastName = Console.ReadLine();

            Console.Write("Enter type of Customer: 1 - Potential, 2 - Current, 3 - Past:");
            var type  = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Please Confirme type of Customer: 1 - Potential, 2 - Current, 3 - Past:");
            string yourResponse = Console.ReadLine();
            int response = int.Parse(yourResponse);
            GreetContent newCustomer = new GreetContent(customerFirstName,customerLastName,(TypeofGreet)type,response);
           _greetRepo.AddGreetContentToList(newCustomer);
            if (response == 1)
            {
                Console.WriteLine("FirstName" + "  " + "  LastName " + "\tType" + "\t\t\t\tEmail");
                foreach (GreetContent content in _greetRepo.GetGreetContentList())
                {
                    Console.WriteLine($"{content.CustomerFirstName}   \t{content.CustomerLastName}  \t{content.Type} \t\t We currently have the lowest rates on Helicopter Insurance!");
                    Console.ReadLine();
                }
            }
            else if (response == 2)
            {
                Console.WriteLine("FirstName" + "  " + "  LastName " + "\tType" + "\t\t\t\tEmail");
                foreach (GreetContent content in _greetRepo.GetGreetContentList())
                {
                    Console.WriteLine($"{content.CustomerFirstName}   \t{content.CustomerLastName}  \t{content.Type} \t\t Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
                    Console.ReadLine();
                }
            }
            else if (response == 3)
            {
                Console.WriteLine("FirstName" + "  " + "  LastName " + "\tType" + "\t\t\t\tEmail");
                foreach (GreetContent content in _greetRepo.GetGreetContentList())
                {
                    Console.WriteLine($"{content.CustomerFirstName}   \t{content.CustomerLastName}  \t{content.Type} \t\t It's been a long time since we've heard from you, we want you back");
                    Console.ReadLine();
                }
            }
        }
       
    }
}

