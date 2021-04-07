using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    public class Appointment
    {
        public Client Client { get; set; } = new Client();
        public string TattooDescription { get; set; }
        public bool HasPreviousTattoos { get; set; }
        public double TattooHeight { get; set; }
        public double TattooWidth { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }

    }
}
