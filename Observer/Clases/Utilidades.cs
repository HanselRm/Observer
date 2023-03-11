using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    static class Utilidades
    {
        public static void Enter(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
        }
    }
}
