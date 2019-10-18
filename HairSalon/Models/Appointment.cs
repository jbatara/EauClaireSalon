using System;

namespace Salon.Models
{
    public class Appointment
    {
        public DateTime ApptDateTime {get;set;}
        public int ClientID {get;set;}
        public int StylistID { get; set; }
        public string Name { get; set; }

    }
}