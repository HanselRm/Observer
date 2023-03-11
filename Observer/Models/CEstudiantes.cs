using Observer.Clases;
using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class CEstudiantes : IObservador
    {
        public string? matricula = "";
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string?  correo { get; set; }

        public void Actualizar()
        {
            CMail.send(correo, nombre);
        }
    }
}
