namespace Salon.Models
{
    public class AppointmentService
    {
        public int AppointmentServiceID {get;set;}
        public int AppointmentID {get;set;}
        public int ServiceID {get;set;}

        public Appointment Appointment {get;set;}

        public Service Service {get;set;}
    }
}