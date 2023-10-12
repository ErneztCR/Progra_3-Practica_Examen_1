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
        static bool inicializado = false;

        public static void desplegar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("-----MENU PRINCIPAL-----");
                Console.WriteLine(" ");
                Console.WriteLine("1. Inicializar programa");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Modificar Estudiantes");
                Console.WriteLine("4. Consultar Estudiantes");
                Console.WriteLine("5. Borrar Estudiantes");
                Console.WriteLine("6. Salir");
                Console.WriteLine(" ");
                Console.Write("Seleccione una opcion: ");

                int.TryParse(Console.ReadLine(), out opcion); // evalua si el valor ingresado es un numero

                if (opcion == 6 && !inicializado)
                {
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa...Saliendo..");
                    continue;
                }
                else if (opcion != 1 && !inicializado)
                {
                    Console.Clear();
                    Console.WriteLine("El programa no ha sido inicializado");
                    Console.WriteLine(" ");
                    Console.WriteLine("Presione cuaquier tecla para volver al MENU,");
                    Console.WriteLine("e inicialice el programa primero");
                    Console.ReadLine();
                    continue;

                }

                switch (opcion)
                {
                    case 1:
                        Cls_Estudiante.Inicializar();
                        inicializado = true;
                        break;
                    case 2:
                        Cls_Estudiante.incluirEstudiante();
                        break;
                    case 3:
                        Console.WriteLine("Modificar Estudiantes");
                        Cls_Estudiante.modificarEstudiante(Cls_Estudiante.BuscarCedula());
                        break;
                    case 4:
                        Console.WriteLine("Consultar Estudiantes");
                        Cls_Estudiante.consultarEstudiante(Cls_Estudiante.BuscarCedula());
                        break;
                    case 5:
                        Console.WriteLine("Borrar Estudiantes");
                        Cls_Estudiante.borrarEstudiante(Cls_Estudiante.BuscarCedula());
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Gracias por usar el programa...Saliendo..");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione cuaquier tecla para volver al MENU");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 6);
        }
    }
}
