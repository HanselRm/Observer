using Observer.Manejadores_de_Modelos;
using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    static class CMenuPrincipal
    {
        public static void Menu()
        {
            List<CEstudiantes> lEstudiante = new List<CEstudiantes>();
            List<CProfesores> lProfesor = new List<CProfesores>();
            List<CEmpleados> lEmpleado = new List<CEmpleados>();

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(@"
                Registro Academico
        
                1- Registrar Estudiante
                2- Registrar Profesor
                3- Registrar Empleado
                4- Configuracion de Materias
                5- Salir
                ");
                Console.WriteLine("Ingrese la opccion deseada");

                int opcion = int.Parse(Console.ReadLine()??"");
                switch(opcion )
                {
                    case 1:
                        Console.Clear();
                        lEstudiante.Add(CManejadorEstudiante.RegistrarEstudiante());
                        Utilidades.Enter("Estudiante Registrado Correctamente");
                        
                        break;

                    case 2:
                        Console.Clear();
                        lProfesor.Add(CManejadorProfesores.RegistrarProfesor());
                        Utilidades.Enter("Profesor Registrado Correctamente");
                        
                        break;

                    case 3:
                        Console.Clear();
                        lEmpleado.Add(CManejadorEmpleados.RegistrarEmpleado());
                        Utilidades.Enter("Empleado Registrado Correctamente");
                        
                        break;

                    case 4:
                        Console.Clear();
                        CMenuMaterias menu = new();
                        menu.MenuMaterias(lEstudiante,lProfesor,lEmpleado);
                        
                        
                        break;

                    case 5:
                        continuar = false;
                        break;

                    default:
                        Utilidades.Enter("Opcion Incorrecta");
                        Console.Clear();
                        break;
                    
                }

            }
        } 
    }
}
