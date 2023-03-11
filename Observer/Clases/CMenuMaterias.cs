using Observer.Manejadores_de_Modelos;
using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
     class CMenuMaterias
    {
        
        List<CMaterias> lMaterias = new List<CMaterias>();
        public  void MenuMaterias(List<CEstudiantes> lEstudiantes, List<CProfesores> lProfesor,
                                            List<CEmpleados> lEmpleado)
        {
            bool continuar = true;
            while (continuar)
            {

                Console.Clear();
                Console.WriteLine(@"
                Registro Academico
        
                1- Registrar Materia
                2- Editar Materia
                3- Salir
                ");
                Console.WriteLine("Ingrese la opccion deseada");

                int opcion = int.Parse(Console.ReadLine() ?? "");
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        lMaterias.Add(CManejadorMateria.RegistrarMateria(lEstudiantes, lProfesor, lEmpleado));
                        Utilidades.Enter("Materia Registrada Correctamente");
                        break;
                    case 2:
                        Console.Clear();
                        lMaterias = (CManejadorMateria.editarMaterias(lMaterias));
                        Utilidades.Enter("Materia Editada Correctamente");
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Utilidades.Enter("Opcion Invalida");
                        break;
                }
            }
        }
    }
}