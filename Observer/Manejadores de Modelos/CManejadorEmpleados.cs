using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Manejadores_de_Modelos
{
    static class CManejadorEmpleados
    {
        public static CEmpleados RegistrarEmpleado()
        {
            CEmpleados empleado = new();

            Console.WriteLine("Ingrese los Siguientes datos del nuevo empleado");

            empleado.codigo = new Random().Next(100, 9999).ToString();

            Console.WriteLine("Nombre");
            empleado.nombre = Console.ReadLine();

            Console.WriteLine("Apellido");
            empleado.apellido = Console.ReadLine();

            Console.WriteLine("Edad");
            try
            {
                empleado.edad = int.Parse(Console.ReadLine() ?? "");
            }

            catch (FormatException ex)
            {
                ex.GetBaseException();
            }

            Console.WriteLine("Correo");
            empleado.correo = Console.ReadLine() ?? "";

            return empleado;

        }

        public static void MostrarEmpleado(List<CEmpleados> lEmpleado)
        {

            foreach (CEmpleados emple in lEmpleado)
            {
                Console.WriteLine(@$"Matricula: {emple.codigo} Nombre: {emple.nombre} {emple.apellido}");
            }

        }
    }
}
