using System.ComponentModel.DataAnnotations;

namespace EpitafioTattoo.Models
{
    public class Client
    {
        [Required(ErrorMessage = "Debe ingeresar el nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de télefono")]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public Client(string firstName, string lastName, string phone, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
        }
    }


}
