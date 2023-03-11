using Observer.Clases;
using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class CEmpleados : IObservador
    {
        public string codigo { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int edad { get; set; }
        public string correo { get; set;}

        public virtual void Actualizar()
        {
            CMail.send(correo, nombre);
        }
    }
}
