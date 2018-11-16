using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class ProgramUI
    {
        BadgeIdRepository _iDRepo = new BadgeIdRepository();
        Badge newBadge = new Badge();
        public void Run()
        {
            Console.WriteLine("Komodo Security\n" +
                "Type your Badge #");
            string password = Console.ReadLine();

            int input = int.Parse(password);
            if (input == 1302)
            {
                Console.WriteLine("Welcome back Edson");
                Console.ReadLine();
                Console.WriteLine($"Hello");
            }
            else if (input == 1303)
            {
                Console.WriteLine("Welcome back Admin");
            }

            bool exit = true;
            while (exit)
            {
                Console.WriteLine(".1 Create Badge\n" +
                   ".2 Delete Badge\n" +
                   ".3 See badge\n" +
                   ".4 Exit ");
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
                        PrintDoors();
                        break;
                    case 4:
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
            PrintDoors();
            Console.WriteLine("What Door you want to delete?");
            var removedoor = Console.ReadLine();

            foreach (string content in _iDRepo.GetContentIdList())
            {
                if (removedoor == content)
                {
                    _iDRepo.RemoveDoorFromList(content);
                    break;
                }


            }
        }
        private void CreateBadge()
        {
            Console.WriteLine("Enter Badge #");
            newBadge.IdNumber = Console.ReadLine();


            Console.WriteLine("Do you want to assign Door to Badge #? (y/n)");
            var input = Console.ReadLine();
            bool addingDoor = _iDRepo.CheckAnswer(input);

            while (addingDoor)
            {
                Console.WriteLine("Door name?");
                var door = Console.ReadLine();
                newBadge.DoorList.Add(door);
        
                _iDRepo.AddBadgeIdToList(door);


                Console.WriteLine("Do you what assign another Door? (y/n)");
                var newInput = Console.ReadLine();
                addingDoor = _iDRepo.CheckAnswer(newInput);
            }
            if (newBadge.DoorList.Count != 0)
            {
                PrintDoors();
            }
            Console.ReadLine();
        }

        private void PrintDoors()
        {
            Console.WriteLine($"Badge #{newBadge.IdNumber}, have access to Door:");

            foreach (string content in _iDRepo.GetContentIdList())
            {
                Console.WriteLine(content);
            }
        }

        private void Register()
        {
            Console.WriteLine("Door name?");
            var door = Console.ReadLine();
            _iDRepo.AddBadgeIdToList(door);

        }
    }
}
