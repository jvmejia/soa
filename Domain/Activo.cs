using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Activos")]
    public class Activo
    {
        [Key]
        public int IdActivo { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set;}
        public virtual ICollection<ActivoEmpleado> ActivosEmpleados { get; set; }

    }
}
