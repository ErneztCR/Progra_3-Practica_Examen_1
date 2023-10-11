using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{

    internal class Cls_Estudiante
    {

        // atributos
        static private int cantidad = 10;
        static public string[] Cedula = new string[cantidad];
        static public string[] Nombre = new string[cantidad];
        static public int[] Nota = new int[cantidad];

        // constructor
        public Cls_Estudiante()
        {

        }

        // metodos
        public static void Inicializar()
        {
            Console.Clear();
            Cedula = Enumerable.Repeat(" ", cantidad).ToArray();
            Nombre = Enumerable.Repeat(" ", cantidad).ToArray();
            Nota = Enumerable.Repeat(0, cantidad).ToArray();
            Console.WriteLine("Vectores inicializados...");
            Console.ReadLine();
        }

        public static void incluirEstudiante()
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la cedula del estudiante");
                Cedula[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del estudiante");
                Nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante");
                int.TryParse(Console.ReadLine(), out Nota[i]);
            }


        }

        public static void modificarEstudiante() {

            string ced = "";   
            Console.WriteLine("Ingrese la cedula del estudiante");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced == Cedula[i])
                {
                    Console.WriteLine("Ingrese el nombre del estudiante");
                    Nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota del estudiante");
                    int.TryParse(Console.ReadLine(), out Nota[i]);
                    break;
                }
            }
        }

        public static void consultarEstudiante()
        {

            string ced = "";
            Console.WriteLine("Ingrese la cedula del estudiante");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced == Cedula[i])
                {
                    Console.WriteLine("Cedula: " + Cedula[i]);
                    Console.WriteLine("Nombre: " + Nombre[i]);
                    Console.WriteLine("Nota: " + Nota[i]);
                    break;
                }
            }
        }

        public static void borrarEstudiante()
        {

            string ced = "";
            Console.WriteLine("Ingrese la cedula del estudiante");
            ced = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (ced == Cedula[i])
                {
                    Cedula[i] = " ";
                    Nombre[i] = " ";
                    Nota[i] = 0;
                    break;
                }
            }
        }
    }
}
