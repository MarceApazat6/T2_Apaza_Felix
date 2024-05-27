using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;


namespace T2_Apaza_Felix.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre de distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage ="La razón social es obligatoria")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage ="El teléfono es obligatorio")]
        public int Telefono { get; set; }
        [Required(ErrorMessage ="El año de Inicio de Operación es obligatorio")]
        [Range(1900,3000,ErrorMessage ="El año debe ser entre 1900 y 3000")]
        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage ="El contacto es Obligatorio")]
        public string Contacto { get; set; }
    }
}
