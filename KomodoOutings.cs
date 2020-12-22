using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings_Repo
{
   
    public class KomodoOutings
    {
        public string EventType { get; set; }
        public string NumberOfPeople { get; set; }
        public string DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostPerEvent { get; set; }

        public KomodoOutings(){}

        public KomodoOutings(string eventType, string numberOfPeople, string dateOfEvent, decimal costPerPerson, decimal costPerEvent)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            CostPerEvent = costPerEvent;
        }
    }
}
