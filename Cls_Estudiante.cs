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
        public static string BuscarCedula() // metodo para buscar un estudiante por cedula
        {
            Console.Clear();
            string ced = "";

            Console.WriteLine("---CONSULTAS DE ESTUDIANTE(S)---");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la cedula del estudiante");
            ced = Console.ReadLine();
            return ced;
        }

        // Inicializa los vectores Cedula, Nombre y Nota con valores vacíos.
        public static void Inicializar()
        {
            Console.Clear();
            Cedula = Enumerable.Repeat(" ", cantidad).ToArray();
            Nombre = Enumerable.Repeat(" ", cantidad).ToArray();
            Nota = Enumerable.Repeat(0.0f, cantidad).ToArray();

            Console.WriteLine("Vectores inicializados...");
            Console.ReadLine();
        }

        // Incluye un nuevo estudiante en los vectores Cedula, Nombre y Nota.
        public static void incluirEstudiante()
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("-------INCLUIR ESTUDIANTE(S)-------");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese la cedula del estudiante " + (i + 1) + "/" + cantidad + ":");
                Cedula[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del estudiante " + (i + 1) + "/" + cantidad + ":");
                Nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + "/" + cantidad + ":");
                float.TryParse(Console.ReadLine(), out Nota[i]);

                Console.Clear();
                Console.WriteLine("Estudiante incluido correctamente");
                Console.ReadLine();
            }
        }

        // Consulta la información de un estudiante por cédula.
        public static void consultarEstudiante(string id)
        {

            for (int i = 0; i < cantidad; i++)
            {
                if (id == Cedula[i])
                {
                    Console.Clear();
                    Console.WriteLine("-------CONSULTA DE ESTUDIANTE-------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cedula\t\tNombre\t\t\tNota");
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{Cedula[i]}\t{Nombre[i]}\t{Nota[i]}");
                    Console.WriteLine("================================================");
                    Console.ReadLine();
                    break;
                }
            }
        }

        // Modifica la información de un estudiante por cédula.
        public static void modificarEstudiante(string id) 
        {

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

        // Elimina la información de un estudiante por cédula.
        public static void eliminarEstudiante(string id)
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
