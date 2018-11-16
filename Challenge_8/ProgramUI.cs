using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    public class ProgramUI
    {
        SmartInsurranceRepository _smartInsurranceRepo = new SmartInsurranceRepository();
        List<SmartInsuranceContent> smartInsuranceList;
        SmartInsuranceContent newSmartContent = new SmartInsuranceContent();
        internal void Run()
        {
            smartInsuranceList = _smartInsurranceRepo.GetSmartInsuranceContentList();
            bool exit = false;
            string userName = "";
            int driverAge = 0;
            int drink = 0;
            int closeAccident = 0;
            int stopSign = 0;
            int lateForWork = 0;
            int hadAccident = 0;

            decimal premium = 0m;

            while (exit == false)
            {
                if (driverAge < 21)
                    premium = 125m;
                else
                    premium = 75m;
                if (drink >= 5)
                    premium += 100m;

                if (closeAccident <= 5)
                    premium += 10m;
                else
                    premium += 25m;
                if (stopSign <= 5)
                    premium += 25m;
                else
                    premium += 75m;
                if (lateForWork <= 3)
                    premium += 10m;
                else
                    premium += 25m;
                if (hadAccident <= 5)
                    premium += 25m;
                else
                    premium += 100m;
                Console.WriteLine($"Thank you for helping us doing the Insurance survey?\n\n" +
                    $"1. Survey\n" +
                    $"2. See your information\n" +
                    $"4. See premium\n" +
                    $"5. Exit");
                int response = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (response)
                {
                    case 1:
                        Console.Write("\nPlease enter your name: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("\nPlease enter your age: ");
                        newSmartContent.DriverAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nHow many nights you like to go out and drink per week?");
                        newSmartContent.Drink = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nHow many close accident you have in a week?: ");
                        newSmartContent.CloseAccident = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nDid you had close accident in a stop sign? if yes how many? if no type (0)");
                        newSmartContent.StopSign = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nhow often you get late to work? if yes how many? if no type (0)");
                        newSmartContent.LateForWork = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nHave you had an accident? is yes how many? is no type (0)");
                        newSmartContent.HadAccident = int.Parse(Console.ReadLine());
                        _smartInsurranceRepo.AddSmartInsuranceContentToList(newSmartContent);
                        break;
                    case 2:
                        foreach(SmartInsuranceContent content in _smartInsurranceRepo.GetSmartInsuranceContentList())
                        Console.WriteLine($"Hello {userName}!\n" +
                            $"Your Age -{content.DriverAge}-\n" +
                            $"Weekly night out -{content.Drink}-, so that is your chances of swerve outside of their lane per week.\n" +
                            $"You had -{content.CloseAccident}- close accident in a week.\n" +
                            $"Close Stop sign accident in a week -{content.StopSign}-\n" +
                            $"You get late for work at least: {content.LateForWork} per week.\n" +
                            $"You had -{content.HadAccident}- accident in an week.\n" +
                            $"Monthly Premium: {premium}");

                        break;
                    case 3:
                        Console.WriteLine("Your monthly premium is $" + premium + ".");
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }
    }
}
