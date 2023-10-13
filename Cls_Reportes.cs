using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    using System;

    namespace PracticaExamen1
    {
        internal class Cls_Reportes
        {
            static string[] cedulas;
            static string[] nombres;
            static float[] notas;

            public static void ConfigurarDatos(string[] cedulas, string[] nombres, float[] notas)
            {
                Cls_Reportes.cedulas = cedulas;
                Cls_Reportes.nombres = nombres;
                Cls_Reportes.notas = notas;
            }

            public static void reporteEstudiantesPorCondicion()
            {
                int opcion = 0;
                do
                {
                    Console.WriteLine("*******Reporte Estudiantes por Condicion******");
                    Console.WriteLine("1. Aprobado(s)");
                    Console.WriteLine("2. Reprobado(s)");
                    Console.WriteLine("3. Aplazado(s)");
                    Console.WriteLine("4. Regresar al Sub-menu");
                    Console.WriteLine("Seleccione una opcion: ");

                    int.TryParse(Console.ReadLine(), out opcion); // evalúa si el valor ingresado es un número

                    switch (opcion)
                    {
                        case 1:
                            Est_aprobados();
                            break;
                        case 2:
                            Est_reprobados();
                            break;
                        case 3:
                            Est_aplazados();
                            break;
                        case 4:
                            // Regresar al menú principal
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opcion no valida");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier tecla para volver al menú");
                            Console.ReadLine();
                            break;
                    }
                } while (opcion != 4);
            }

            public static void Est_aprobados()
            {
                int numEstudiantesRegistrados = cedulas.Length;
                bool NohayEstu_Apro = true;

                if (numEstudiantesRegistrados > 0)
                { // Verifica que hayan estudiantes dentro del sistema.
                    Console.WriteLine("Estudiantes Aprobados: ");
                    for (int i = 0; i < numEstudiantesRegistrados; i++)
                    {
                        if (notas[i] >= 70)
                        { // Verifica si hay estudiantes aprobados.
                            Console.WriteLine("Cedula: " + cedulas[i]
                                    + " Nombre: " + nombres[i]
                                    + " Nota: " + notas[i]);
                            NohayEstu_Apro = false;
                        }
                    }
                    if (NohayEstu_Apro)
                    {
                        Console.WriteLine("\033[1mNo hay estudiantes aprobados.\033[0m\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n\033[1mNo hay estudiantes registrados.\033[0m");
                }
            }

            public static void Est_reprobados()
            {
                int numEstudiantesRegistrados = cedulas.Length;

                if (numEstudiantesRegistrados > 0)
                { // Verifica que hayan estudiantes dentro del sistema.
                    Console.WriteLine("Estudiantes Reprobados:");
                    bool hayEstudiantesReprobados = true;
                    for (int i = 0; i < numEstudiantesRegistrados; i++)
                    {
                        if (notas[i] <= 59)
                        {// Verifica si hay estudiantes reprobados.
                            Console.WriteLine("Cedula: " + cedulas[i]
                                    + " Nombre: " + nombres[i]
                                    + " Nota: " + notas[i]);
                            hayEstudiantesReprobados = false;
                        }
                    }
                    if (hayEstudiantesReprobados)
                    {
                        Console.WriteLine("\n\033[1mNo hay estudiantes reprobados.\033[0m");
                    }
                }
                else
                {
                    Console.WriteLine("\n\033[1mNo hay estudiantes registrados.\033[0m");
                }
            }

            public static void Est_aplazados()
            {
                int numEstudiantesRegistrados = cedulas.Length;

                if (numEstudiantesRegistrados > 0)
                {// Verifica que hayan estudiantes dentro del sistema.
                    Console.WriteLine("Estudiantes Aplazados:");
                    bool hayEstudiantesAplazados = true;
                    for (int i = 0; i < numEstudiantesRegistrados; i++)
                    { // Verifica si hay estudiantes aplazados.
                        if (notas[i] < 70 && notas[i] >= 60)
                        {
                            hayEstudiantesAplazados = false;
                            Console.WriteLine("Cedula: " + cedulas[i]
                                    + " Nombre: " + nombres[i]
                                    + " Nota: " + notas[i]);
                        }
                    }
                    if (hayEstudiantesAplazados)
                    {
                        Console.WriteLine("\n\033[1mNo hay estudiantes aplazados.\033[0m");
                    }
                }
                else
                {
                    Console.WriteLine("\n\033[1mNo hay estudiantes registrados.\033[0m");
                }
            }
        }
    }
}
