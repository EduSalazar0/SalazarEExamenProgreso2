using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalazarEExamenProgreso2.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El numero es necesario")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El numero de telefono es necesario")]
        public string Numero { get; set; }

        
    }
}
