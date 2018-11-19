using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class ProgramUI
    {
        BadgeContent newBadgeContent = new BadgeContent();
        BadgeRepository _iDRepo = new BadgeRepository();
        Dictionary<int, List<string>> badgeID = new Dictionary<int, List<string>>();
        public void Run()
        {
            Console.Write("Komodo Security\n" +
                "Type your Badge #");
            int badgeNumber = int.Parse(Console.ReadLine());

            if (badgeNumber == 1302)
            {
                Console.WriteLine("Welcome back Edson");
                Console.ReadLine();
                Console.WriteLine($"Hello");
            }
            else if (badgeNumber == 1303)
            {
                Console.WriteLine("Welcome back Admin");
            }

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
                        PrintDoors();
                        break;
                    case 4:
                        UpdateDoor();
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
        private void UpdateDoor()
        {

            Dictionary<int, List<string>> badgeID = _iDRepo.GetBadge();
            List<string> listOfDoors = _iDRepo.GetList();
            Console.Clear();
            Console.Write("Current badges: ");
            foreach (KeyValuePair<int, List<string>> IdNumber in _iDRepo.GetBadge())
            {
                Console.Write($" {IdNumber.Key}\n");
            }
            //Console.WriteLine();
            Console.Write("\nBe aware that all doors Assigned to this Badge # will be delete.\n" +
                "Do you want to continue? (y/n):");
            var input = Console.ReadLine().ToLower();
            if (input != "y") { return; }
            Console.WriteLine();
            {
                Console.Write("\nEnter Badge #: ");
                int badgeid = int.Parse(Console.ReadLine());
                foreach (KeyValuePair<int, List<string>> IdNumber in _iDRepo.GetBadge())
                {
                    if (badgeid == IdNumber.Key)
                    {
                        //Console.WriteLine();
                        Console.Write("\nThis Badge currently has no doors assigned. Do you want to add a door to this badge? (y/n): ");
                        var dooranswer = Console.ReadLine().ToLower();
                        bool addingdoors = _iDRepo.CheckAnswer(dooranswer);
                        while (addingdoors)
                        {
                            //Console.WriteLine();
                            Console.WriteLine("\nEnter door name(s) ex:(A2,A3 or A1,golden,blue:");
                            var doorname = Console.ReadLine();
                            _iDRepo.AddDoorToList(doorname);
                            //Console.WriteLine();
                            Console.Write("Do you want to add another door? (y/n): ");
                            var answer = Console.ReadLine().ToLower();
                            addingdoors = _iDRepo.CheckAnswer(answer);
                        }
                    }
                    else { return; }
                }
                badgeID[badgeid] = listOfDoors;
                Console.WriteLine();
            }
        }
        private void Delete()
        {
            Dictionary<int, List<string>> badges = _iDRepo.GetBadge();

            foreach (KeyValuePair<int, List<string>> badge in badges)
            {
                Console.Write("Badge = {0}, Doors = ", badge.Key);
                foreach (string content in badge.Value)
                {
                    Console.Write(content + " ");
                }
            }
            Console.WriteLine();
            Console.Write("What Badge do you want to remove?");


            int input = int.Parse(Console.ReadLine());
            _iDRepo.RemoveBadgeFromList(input);

            if (!badges.ContainsKey(input))

            {
                Console.WriteLine("Key Badge was delete");
            }


        }



        private void CreateBadge()
        {
            Console.Clear();
            List<string> doors = new List<string>();
            Console.Write("Enter Badge # ");
            int badgeId = int.Parse(Console.ReadLine());


            Console.Write("Do you want to assign Door to Badge #? (y/n):");
            var input = Console.ReadLine();
            bool addingDoor = _iDRepo.CheckAnswer(input);

            while (addingDoor)
            {
                Console.Write("Door name? ");
                var door = Console.ReadLine();
                doors.Add(door);

                Console.Write("Do you what assign another Door? (y/n): ");
                var newInput = Console.ReadLine();
                addingDoor = _iDRepo.CheckAnswer(newInput);
            }

            BadgeContent badge = new BadgeContent(badgeId, doors);

            _iDRepo.AddBadgeToDictionary(badge);
        }

        private void PrintDoors()
        {
            Console.Clear();
            Dictionary<int, List<string>> doors = _iDRepo.GetBadge();

            foreach (KeyValuePair<int, List<string>> badge in doors)
            {
                Console.Write("Badge = {0}, Doors = ", badge.Key);
                foreach (string content in badge.Value)
                {
                    Console.Write(content + ": ");
                }
            }
            Console.WriteLine();
        }
    }
}
