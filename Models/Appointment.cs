using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    public class Appointment
    {
        //public Client Client { get; set; } = new Client();

        [Required(ErrorMessage = "Debe ingeresar el nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de télefono")]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingressar una descripción")]
        public string TattooDescription { get; set; }

        public bool HasPreviousTattoos { get; set; }

        [Required(ErrorMessage = "Debe ingresar la altura del tatuaje")]
        public double TattooHeight { get; set; }

        [Required(ErrorMessage = "Debe ingresar el ancho del mesaje")]
        public double TattooWidth { get; set; }
              
        [Required(ErrorMessage = "Debe ingresar la fecha del tatuaje")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Debe ingresar la hora del tatuaje")]
        public DateTime? Time { get; set; }

        public DateTime DateAndTime { get; set; }

        public string Photo { get; set; }

    }
}
