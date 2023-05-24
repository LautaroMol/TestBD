using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titulosapp3.BD.Data.Entity
{
    public class Persona
    {
        public int Id { get; set; }
        public string Dni { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
    }
}
