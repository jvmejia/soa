using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int Id_Persona { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(20)]
        public string CURP { get; set; }
        [Column(TypeName ="date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set;}

    }
}
