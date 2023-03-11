using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interface
{
    internal interface IObservable
    {
        public void Agregar(IObservador objeto);
        public void Eliminar(IObservador objeto);
        public void Notificar();
    }
}

