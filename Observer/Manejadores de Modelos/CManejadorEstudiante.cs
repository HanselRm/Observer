using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Manejadores_de_Modelos
{
    static class CManejadorEstudiante
    {
        public static CEstudiantes RegistrarEstudiante()
        {
            CEstudiantes estudiante = new();

            Console.WriteLine("Ingrese los siguientes datos del nuevo estudiante");

            Console.WriteLine("Matricula");
            estudiante.matricula = Console.ReadLine();

            Console.WriteLine("Nombre");
            estudiante.nombre = Console.ReadLine();

            Console.WriteLine("Apellido");
            estudiante.apellido = Console.ReadLine();

            Console.WriteLine("Correo");
            estudiante.correo = Console.ReadLine();

            return estudiante;

        }

        public static void MostrarEstudiantes(List<CEstudiantes> lEstudiantes)
        {

            foreach (CEstudiantes estu in lEstudiantes)
            {
                Console.WriteLine(@$"Matricula: {estu.matricula} Nombre: {estu.nombre}");
            }

        }
    }
}
