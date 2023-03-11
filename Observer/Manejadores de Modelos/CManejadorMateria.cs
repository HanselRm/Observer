using Observer.Manejadores_de_Modelos;
using Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
     class CManejadorMateria
    {
        
        public static CMaterias RegistrarMateria(List<CEstudiantes> lEstudiantes, List<CProfesores> lProfesor, 
                                            List<CEmpleados> lEmpleado)
        {
            CMaterias materia = new();

            Console.WriteLine("Ingrese los Siguientes datos");

            Console.WriteLine("Nombre");
            materia.nombre = Console.ReadLine()??"";

            Console.WriteLine("Ingrese la matricula del estudiante que quiere registrar en esta materia");
            CManejadorEstudiante.MostrarEstudiantes(lEstudiantes);

            string codigo = Console.ReadLine()??"";

            try
            {
                materia.Agregar(lEstudiantes.Find(x => x.matricula == codigo));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Se ha producido un error {ex.Message}");
            }



            Console.WriteLine("Ingrese el codigo del profesor que quiere registrar en esta materia");
            CManejadorProfesores.MostrarProfesor(lProfesor);


            codigo = Console.ReadLine() ?? "";
            materia.Agregar(lProfesor.Find(x => x.codigo == codigo));

            Console.WriteLine("Ingrese el codigo del empleado que quiere registrar en esta materia");
            CManejadorEmpleados.MostrarEmpleado(lEmpleado);


            codigo = Console.ReadLine() ?? "";
            materia.Agregar(lEmpleado.Find(x => x.codigo == codigo));


            Console.WriteLine(@"Esta materia tiene cupos?
             Escriba si o no");

            string respuesta = Console.ReadLine() ?? "";

                if(respuesta.ToLower() == "si")
                {
                materia.cuposDeMateria(true);
                }
                else if (respuesta.ToLower() == "no")
                {
                    materia.cuposDeMateria(false);
                }
                else
                {
                    Console.WriteLine("Opcion invalida, se tomara como si la materia esta vacia");
                    materia.cuposDeMateria(false);
                }
                
            return materia;
        }

        public static List<CMaterias> editarMaterias(List<CMaterias> lMaterias)
        {
            foreach(var materias in lMaterias)
            {
                
                Console.WriteLine($" Nombre: {materias.nombre}");
            }
            Console.WriteLine("Ingrese la materia que quiera editar");
            string nom = Console.ReadLine() ?? "";
             
            foreach(var materia in lMaterias)
            {
                if (materia.nombre == nom)
                {
                    Console.WriteLine("Ingrese un nuevo nombre");
                    materia.nombre = Console.ReadLine()??"";

                    Console.WriteLine("Ingrese un nuevo estado de la seccion, Escriba si si esta llena o no si no lo esta");
                    string respuesta = Console.ReadLine() ?? "";

                    if (respuesta.ToLower() == "si")
                    {
                        materia.cuposDeMateria(true);
                    }
                    else if (respuesta.ToLower() == "no")
                    {
                        materia.cuposDeMateria(false);
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida, se tomara como si la materia esta vacia");
                        materia.cuposDeMateria(false);
                    }
                }
            }
            return lMaterias;
        }

    

    }
}
