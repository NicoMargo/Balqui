using Balqui.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Balqui.Models
{
    public class Transaction
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El cliente es obligatorio")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "La descripcion debe tener de 2 a 1000 caracteres")]
        public string Client { get; set; }

        [Required(ErrorMessage = "El tipo de pago es obligatorio")]
        [Range(1, byte.MaxValue)]
        public byte IdPaymentType { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatorio")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "La descripcion debe tener de 2 a 1000 caracteres")]
        [NoEmptySpaces]
        public string Description { get; set; }

        [Required(ErrorMessage = "El monto es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
        public decimal Amount {  get; set; }

        public Transaction()
        {

        }
    }
}
