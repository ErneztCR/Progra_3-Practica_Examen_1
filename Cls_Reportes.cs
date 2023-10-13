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
            public static void reporteEstudiantesPorCondicion()
            {
                int opcion = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Reporte Estudiantes por Condición");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Aprobado(s)");
                    Console.WriteLine("2. Reprobado(s)");
                    Console.WriteLine("3. Aplazado(s)");
                    Console.WriteLine("4. Regresar al Sub-menu");
                    Console.WriteLine(" ");
                    Console.Write("Seleccione una opción: ");

                    int.TryParse(Console.ReadLine(), out opcion);

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
                            Cls_subMenu.desplegarsubMenu();
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier tecla para volver al menú");
                            Console.ReadLine();
                            break;
                    }
                } while (opcion != 4);
            }

            public static void Est_aprobados()
            {
                Console.Clear();
                Console.WriteLine("Estudiantes Aprobados: ");
                bool estudiantesAprobados = false;

                for (int i = 0; i < Cls_Estudiante.Cedula.Length; i++)
                {
                    if (Cls_Estudiante.Nota[i] >= 70)
                    {
                        Console.WriteLine("Cedula: " + Cls_Estudiante.Cedula[i]);
                        Console.WriteLine("Nombre: " + Cls_Estudiante.Nombre[i]);
                        Console.WriteLine("Nota: " + Cls_Estudiante.Nota[i]);
                        estudiantesAprobados = true;
                    }
                }

                if (!estudiantesAprobados)
                {
                    Console.WriteLine("No hay estudiantes aprobados.");
                }

                Console.ReadLine();
            }

            public static void Est_reprobados()
            {
                Console.Clear();
                Console.WriteLine("Estudiantes Reprobados:");
                bool estudiantesReprobados = false;

                for (int i = 0; i < Cls_Estudiante.Cedula.Length; i++)
                {
                    if (Cls_Estudiante.Nota[i] < 60)
                    {
                        Console.WriteLine("Cedula: " + Cls_Estudiante.Cedula[i]);
                        Console.WriteLine("Nombre: " + Cls_Estudiante.Nombre[i]);
                        Console.WriteLine("Nota: " + Cls_Estudiante.Nota[i]);
                        estudiantesReprobados = true;
                    }
                }

                if (!estudiantesReprobados)
                {
                    Console.WriteLine("No hay estudiantes reprobados.");
                }

                Console.ReadLine();
            }

            public static void Est_aplazados()
            {
                Console.Clear();
                Console.WriteLine("Estudiantes Aplazados:");
                bool estudiantesAplazados = false;

                for (int i = 0; i < Cls_Estudiante.Cedula.Length; i++)
                {
                    if (Cls_Estudiante.Nota[i] >= 60 && Cls_Estudiante.Nota[i] < 70)
                    {
                        Console.WriteLine("Cedula: " + Cls_Estudiante.Cedula[i]);
                        Console.WriteLine("Nombre: " + Cls_Estudiante.Nombre[i]);
                        Console.WriteLine("Nota: " + Cls_Estudiante.Nota[i]);
                        estudiantesAplazados = true;
                    }
                }

                if (!estudiantesAplazados)
                {
                    Console.WriteLine("No hay estudiantes aplazados.");
                }

                Console.ReadLine();
            }

            // Imprime un reporte con todos los datos de los estudiantes.
            public static void reporteTodosLosDatos(string[] cedulas, string[] nombres, float[] notas, string[] condiciones)
            {
                int numEstudiantes = cedulas.Length;

                if (numEstudiantes > 0)
                {
                    // Ordena los estudiantes por nota de mayor a menor
                    for (int i = 0; i < numEstudiantes - 1; i++)
                    {
                        for (int j = 0; j < numEstudiantes - i - 1; j++)
                        {
                            if (notas[j] < notas[j + 1])
                            {
                                // Realiza un intercambio en todos los arrays
                                Swap(ref cedulas[j], ref cedulas[j + 1]);
                                Swap(ref nombres[j], ref nombres[j + 1]);
                                Swap(ref notas[j], ref notas[j + 1]);
                                Swap(ref condiciones[j], ref condiciones[j + 1]);
                            }
                        }
                    }

                    // Imprime el encabezado del reporte
                    Console.WriteLine("Cedula\t\t\tNombre\t\t\tNota\t\t\tCondicion");
                    Console.WriteLine("============================================");

                    // Imprime los datos de los estudiantes ordenados
                    for (int i = 0; i < numEstudiantes; i++)
                    {
                        Console.WriteLine($"{cedulas[i]}\t\t\t{nombres[i]}\t\t\t{notas[i]}\t\t\t{condiciones[i]}");
                        Console.WriteLine("============================================");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo hay estudiantes registrados.");
                }
            }

            // Intercambia los valores de dos variables para ordenar los estudiantes por nota de mayor a menor
            private static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }

        }
    }
}
