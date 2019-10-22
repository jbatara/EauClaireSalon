using System;
using System.Collections.Generic;

namespace Salon.Models
{
    public class Appointment
    {
        public int AppointmentID {get;set;}
        public DateTime ApptDateTime {get;set;}
        public bool Paid {get;set;}
        public int ClientID {get;set;}
        public int StylistID { get; set; }
        public virtual ICollection<AppointmentService> AppointmentServices {get;set;}

    }
}