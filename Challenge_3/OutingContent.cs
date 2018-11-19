using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum OutingEvent {AmusementPark =1, Bowling, GolfGame, Concert }
    public class OutingContent
    {
        public OutingEvent TypeOfEvent { get; set; }
        public int NumberOFCustomer { get; set; }
        public DateTime OutingDate { get; set; }
        public decimal PersonCost { get; set; }
        public decimal EventCost { get; set; }

        public OutingContent(OutingEvent typeOfEvent, int numberOfCustomer, DateTime outingDate, decimal personalCost, decimal eventCost)
        {
            TypeOfEvent = typeOfEvent;
            NumberOFCustomer = numberOfCustomer;
            OutingDate = outingDate;
            PersonCost = personalCost;
            EventCost = eventCost;
        }
        public OutingContent()
        {

        }
    }
}


