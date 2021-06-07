using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    public class EditVideoModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El Link es obligatorio")]
        public string Link { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Description { get; set; }
    }
}
