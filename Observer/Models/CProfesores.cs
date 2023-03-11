
using Observer.Clases;
using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Observer.Models
{
    internal class CProfesores : CEmpleados
    {
        public  override void Actualizar()
        {
            CMail.send(correo, nombre);
        }
    }
}
