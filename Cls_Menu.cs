using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class Cls_Menu
    {

        static int opcion = 0;

        public static void desplegar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Inicializar arreglos");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Modificar Estudiantes");
                Console.WriteLine("4. Consultar Estudiantes");
                Console.WriteLine("5. Borrar Estudiantes");
                Console.WriteLine("6. Salir");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Inicializar arreglos");
                        Cls_Estudiante.Inicializar();
                        break;
                    case 2:
                        Console.WriteLine("Incluir Estudiantes");
                        Cls_Estudiante.incluirEstudiante();
                        break;
                    case 3: 
                        Console.WriteLine("Modificar Estudiantes");
                        Cls_Estudiante.modificarEstudiante();
                        break;
                    case 4:
                        Console.WriteLine("Consultar Estudiantes");
                        Cls_Estudiante.consultarEstudiante();
                        break;
                    case 5:
                        Console.WriteLine("Borrar Estudiantes");
                        Cls_Estudiante.borrarEstudiante();
                        break;

                    case 6:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine(" ");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
