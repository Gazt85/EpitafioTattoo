using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    public class VideoItemModel
    {
        [Required(ErrorMessage = "El link es obligatorio")]
        public string Link { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Title { get; set; }
   
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }

        public string ImageSource { get; set; }
    }
}
