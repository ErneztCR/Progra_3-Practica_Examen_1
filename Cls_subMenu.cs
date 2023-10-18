using PracticaExamen1.PracticaExamen1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class Cls_subMenu
    {

        static int opcion = 0;

        public static void desplegarsubMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------SUB-MENU--------");
                Console.WriteLine(" ");
                Console.WriteLine("1. Reporte Estudiantes por Condición");
                Console.WriteLine("2. Reporte Todos los datos");
                Console.WriteLine("3. Regresar Menu Principal");
                Console.WriteLine(" ");
                Console.Write("Seleccione una opcion: ");

                int.TryParse(Console.ReadLine(), out opcion); // evalua si el valor ingresado es un numero

                switch (opcion)
                {
                    case 1: // Reporte Estudiantes por Condición
                        Cls_Reportes.reporteEstudiantesPorCondicion();
                        break;
                    case 2: // Reporte Todos los datos
                        Cls_Reportes.reporteTodosLosDatos();
                        break;
                    case 3: // regresar al menu principal
                        Cls_Menu.desplegar();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione cuaquier tecla para volver al SUB-MENU");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);
        }
    }
}
