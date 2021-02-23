using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    public class Appointment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string TattooDescription { get; set; }
        public bool HasPreviousTattoos { get; set; }
        public double TattooDimension { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }

    }
}
