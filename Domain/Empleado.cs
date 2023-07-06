using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Empleado : Persona
    {
       
        [Required]
        public int NumEmpleado { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public DateTime FechaIngresoEmpresa { get; set; }
        [Required]
        public Boolean Estatus { get; set; }    

        public virtual ICollection<ActivoEmpleado> ActivosEmpleados { get; set; }


    }
}
