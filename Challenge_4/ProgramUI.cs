using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    public class ProgramUI
    {
        BadgeRepository _iDRepo = new BadgeRepository();

        public void Run()
        {
            Console.WriteLine("Komodo Security\n" +
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
            Console.WriteLine("What Badge do you want to remove?");


            int input = int.Parse(Console.ReadLine());
            _iDRepo.RemoveBadgeFromList(input);

            if (!badges.ContainsKey(input))

            {
                Console.WriteLine("Key Badge was delete");
            }


        }



        private void CreateBadge()
        {
            List<string> doors = new List<string>();
            Console.WriteLine("Enter Badge #");
            int badgeId = int.Parse(Console.ReadLine());


            Console.WriteLine("Do you want to assign Door to Badge #? (y/n)");
            var input = Console.ReadLine();
            bool addingDoor = _iDRepo.CheckAnswer(input);

            while (addingDoor)
            {
                Console.WriteLine("Door name?");
                var door = Console.ReadLine();
                doors.Add(door);

                Console.WriteLine("Do you what assign another Door? (y/n)");
                var newInput = Console.ReadLine();
                addingDoor = _iDRepo.CheckAnswer(newInput);
            }

            BadgeContent badge = new BadgeContent(badgeId, doors);

            _iDRepo.AddBadgeToDictionary(badge);
        }

        private void PrintDoors()
        {

            Dictionary<int, List<string>> doors = _iDRepo.GetBadge();

            foreach (KeyValuePair<int, List<string>> badge in doors)
            {
                Console.Write("Badge = {0}, Doors = ", badge.Key);
                foreach (string content in badge.Value)
                {
                    Console.Write(content + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
