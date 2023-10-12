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
        static private int cantidad = 3;
        static public string[] Cedula = new string[cantidad];
        static public string[] Nombre = new string[cantidad];
        static public float[] Nota = new float[cantidad];

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
            Nota = Enumerable.Repeat(0.0f, cantidad).ToArray();

            Console.WriteLine("Vectores inicializados...");
            Console.ReadLine();
        }

        // metodo para buscar un estudiante por cedula
        public static string BuscarCedula() 
        {
            string ced = "";
            Console.WriteLine("Ingrese la cedula del estudiante");
            ced = Console.ReadLine();
            return ced;
        }

        public static void incluirEstudiante()
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("-------Incluir Estudiantes-------");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese la cedula del estudiante " + (i + 1) + "/" + cantidad + ":");
                Cedula[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del estudiante " + (i + 1) + "/" + cantidad + ":");
                Nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + "/" + cantidad + ":");
                float.TryParse(Console.ReadLine(), out Nota[i]);
            }


        }

        public static void modificarEstudiante(string id) {

            for (int i = 0; i < cantidad; i++)
            {
                if (id == Cedula[i])
                {
                    Console.WriteLine("Ingrese el nuevo nombre del estudiante:");
                    Nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva nota del estudiante:");
                    float.TryParse(Console.ReadLine(), out Nota[i]);
                    break;
                }
            }
        }

        public static void consultarEstudiante(string id)
        {

            for (int i = 0; i < cantidad; i++)
            {
                if (id == Cedula[i])
                {
                    Console.WriteLine("Cedula: " + Cedula[i]);
                    Console.WriteLine("Nombre: " + Nombre[i]);
                    Console.WriteLine("Nota: " + Nota[i]);
                    break;
                }
            }
        }

        public static void borrarEstudiante(string id)
        {

            for (int i = 0; i < cantidad; i++)
            {
                if (id == Cedula[i])
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
