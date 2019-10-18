using System;

namespace Salon.Models
{
    public class Appointment
    {
        public int AppointmentID {get;set;}
        public DateTime ApptDateTime {get;set;}
        public bool Paid {get;set;}
        public int ServiceID {get;set;}
        public int ClientID {get;set;}
        public int StylistID { get; set; }
    }
}