using System.ComponentModel.DataAnnotations;

namespace Balqui.Models
{
    public class PaymentType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Tipo de pago es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener de 2 a 100 caracteres")]
        public string Name { get; set; }        

        public PaymentType()
        {

        }
    }
}
