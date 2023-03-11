using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class CMaterias : IObservable
    {
        public string nombre { get; set; }

        public List<IObservador> listaInteresados = new List<IObservador>();
        private string seccionLlena { get; set; }



        public void Agregar(IObservador objeto)
        {
            try
            {
                listaInteresados.Add(objeto);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Se ha producido un error {ex.Message}");
            }


        }

        public void Eliminar(IObservador objeto)
        {
            listaInteresados.Remove(objeto);
        }

        public void Notificar()
        {
            try
            {
                foreach (var estu in listaInteresados)
                {
                 
                    estu.Actualizar();

                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Error registre la materia nuevamente");
            }
            
        }
            
            

        public void cuposDeMateria(bool respuesta)
        {
            if (respuesta)
            {
                seccionLlena = "Llena";
            }
            else
            {
                seccionLlena = "Libre";
            }
            Notificar();
        }

    }
}
