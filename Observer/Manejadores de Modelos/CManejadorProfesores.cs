using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Manejadores_de_Modelos
{
    internal class CManejadorProfesores
    {
        public static CProfesores RegistrarProfesor()
        {
            CProfesores profesor = new();

            Console.WriteLine("Ingrese los Siguientes datos del nuevo profesor");

            profesor.codigo =  new Random().Next(100, 9999).ToString();

            Console.WriteLine("Nombre");
            profesor.nombre = Console.ReadLine();

            Console.WriteLine("Apellido");
            profesor.apellido = Console.ReadLine();

            Console.WriteLine("Edad");
            try
            {
               profesor.edad = int.Parse(Console.ReadLine()??"");
            }

            catch (FormatException ex)
            {
                ex.GetBaseException();
            }

            Console.WriteLine("Correo");
            profesor.correo = Console.ReadLine()??"";
            return profesor;

        }

        public static void MostrarProfesor(List<CProfesores> lProfesores)
        {

            foreach (CProfesores profe in lProfesores)
            {
                Console.WriteLine(@$"Matricula: {profe.codigo} Nombre: {profe.nombre} {profe.apellido}");
            }

        }
    }
}
