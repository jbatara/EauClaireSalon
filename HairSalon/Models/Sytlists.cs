namespace Salon.Models
{
    public class Stylist
    {
        public int StylistID { get; set; }
        public int StylistTier {get;set;}
        public string Name {get;set;}

        public string Title()
        {
            if(StylistTier == 3)
            {
                return "Master Stylist";
            }
            else if (StylistTier == 2)
            {
                return "Stylist";
            }
            else
            {
                return "Apprentice";
            }
        }
        
    }


}