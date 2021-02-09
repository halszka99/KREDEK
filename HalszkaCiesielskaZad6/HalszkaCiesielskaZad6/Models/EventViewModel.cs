using System;

namespace HalszkaCiesielskaZad6.Models
{
    public class EventViewModel
    {
        // animal taking part in event 
        public AnimalViewModel Animal { get; set; }
        // date of event
        public DateTime Date { get; set; }
        // time of event
        public TimeSpan Time { get; set; }
        // ticket price
        public decimal TicketPrice { get; set; }
    }
}
