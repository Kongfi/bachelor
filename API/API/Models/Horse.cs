using System;

namespace API.Models
{
    public class Horse
    {
        public string FeifID { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public string Stable { get; set; }
        public string Gender { get; set; }
        public int BirthYear { get 
            {
                return int.Parse(FeifID.Substring(2, 4));
            }
        }
    }
}
