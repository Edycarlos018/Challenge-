using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepository _outingRepo = new OutingRepository();
        private List<OutingContent> outingContentList;
        internal void Run()
        {
            OutingDisplayContent();
            outingContentList = _outingRepo.GetOutingContentList();
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Komodo Outing System:\n" +
                    ".1 Display List of Outing\n" +
                    ".2 Add Outing\n" +
                    ".3 Costs Outing\n" +
                    ".4 Combine Outing\n" +
                    ".5 Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                           // Console.Clear();
                            Console.WriteLine("Type" + "   " + "\t\tCustomer #" + "\t\t\tDate" + "\t\t\tEntry Cost" + "\tEventCost");
                            foreach (OutingContent content in _outingRepo.GetOutingContentList())
                            {
                                Console.WriteLine($"{content.TypeOfEvent} \t\t{content.NumberOFCustomer} \t\t{content.OutingDate} \t\t{content.PersonCost} \t\t{content.EventCost}");
                                Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        AddOuting();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Choose Step:\n" +
             "1. Show individual year outing cost\n" +
             "2. Show combine year outing cost");
                        int response = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (response)
                        {
                            case 1:
                                Console.WriteLine("Type" + "   " + "\t\t\tEventCost");
                                foreach (OutingContent content in _outingRepo.GetOutingContentList())
                                {
                                    Console.WriteLine($"{content.TypeOfEvent} \t\t{content.PersonCost}");
                                    Console.ReadLine();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Type" + "   " + "\t\t\tEventCost");
                                foreach (OutingContent content in _outingRepo.GetOutingContentList())
                                {
                                    Console.WriteLine($"{content.TypeOfEvent} \t\t{content.EventCost}");
                                    Console.ReadLine();
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid Input");
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Combine Cost: ${_outingRepo.GetTotalOutingCost()}");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            }

        }


        private void AddOuting()
        {
            //Console.Clear();
            Console.WriteLine("Enter the number for the outing you want to create: (Amusementpark-1/Bowling-2/Golf-3/Concert-4)");
            var typeofevent = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer #");
            var numberofcustomer = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter event date (YYYY/MM/DD");
            var eventdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter cost per person (0.00)");
            var costperperson = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter event total Cost (0.00)");
            var eventtotalcost = decimal.Parse(Console.ReadLine());
            OutingContent newOuting = new OutingContent((OutingEvent)typeofevent, numberofcustomer, eventdate, costperperson, eventtotalcost);

            _outingRepo.AddOutingContentToList(newOuting);

            Console.WriteLine("Type" + "   " + "\t\tCustomer #" + "\t\t\tDate" + "\t\t\tEntry Cost" + "\tEventCost");
            foreach (OutingContent content in _outingRepo.GetOutingContentList())
            {
                Console.WriteLine($"{content.TypeOfEvent} \t\t{content.NumberOFCustomer} \t\t{content.OutingDate} \t\t{content.PersonCost} \t\t{content.EventCost}");
                Console.ReadLine();
            }
        }


        private void OutingDisplayContent()
        {

            OutingContent AmusementPark = new OutingContent(OutingEvent.AmusementPark, 20, new DateTime(2018 / 11 / 14), 25, 500);
            OutingContent Bowling = new OutingContent(OutingEvent.Bowling, 30, new DateTime(2018 / 11 / 14), 9.50m, 285);
            OutingContent Golf = new OutingContent(OutingEvent.GolfGame, 10, new DateTime(2018 / 11 / 14), 10.30m, 130);
            OutingContent Concert = new OutingContent(OutingEvent.Concert, 40, new DateTime(2018, 11, 14), 100, 4000);
            _outingRepo.AddOutingContentToList(AmusementPark);
            _outingRepo.AddOutingContentToList(Bowling);
            _outingRepo.AddOutingContentToList(Golf);
            _outingRepo.AddOutingContentToList(Concert);
           // Console.Clear();
        }

       /*
        public static string TypeOfEvent(Outing outing)
        {
            switch (outing)
            {
                case Outing.GolfGame:
                    return "GolfGame";
                case Outing.AmusementPark:
                    return "Amusement Park";
                case Outing.Bowling:
                    return "Bowling";
                case Outing.Concert:
                    return "Concert";
                default:
                    return "Invalid Input";
            }
        }
        */
    }
}
