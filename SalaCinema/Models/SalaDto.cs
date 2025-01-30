using System.ComponentModel.DataAnnotations;

namespace SalaCinema.Models
{
    public class SalaDto
    {
        //public string Id { get; set; }

        [Display(Name = "Descrição")]
        public string Name { get; set; }
        [Display(Name = "N° Sala")]
        public int NumberRoom { get; set; }
        //public bool Active { get; set; }
    }
}
