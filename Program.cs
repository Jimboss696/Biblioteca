using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // Clase principal del programa, que contiene el menú interactivo
    class Program
    {
        static Biblioteca biblioteca = new Biblioteca("Biblioteca Central");

        static void Main(string[] args)
        {
            Menu();
        }

        // Menú interactivo que permite al usuario realizar diferentes operaciones
        static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();               
                Console.WriteLine("=============================");
                Console.WriteLine("                             ");
                Console.WriteLine("  Bibloteca el conocimiento  ");
                Console.WriteLine("                             ");
                Console.WriteLine("=============================");
                Console.WriteLine("===******** Menú *********===");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Eliminar libro");
                Console.WriteLine("3. Mostrar libros registrados");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                // Opciones del menú que llaman a diferentes métodos
                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;
                    case 2:
                        EliminarLibro();
                        break;
                    case 3:
                        MostrarLibros();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4); // El ciclo continúa hasta que se selecciona la opción de salir
        }

        // Método para agregar un libro a la biblioteca
        static void AgregarLibro()
        {
            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();
            Console.Write("Ingrese el género del libro: ");  // Nueva solicitud para el género
            string genero = Console.ReadLine();

            Libro libro = new Libro(titulo, autor, isbn, genero);  // Se incluye el género en la creación del libro
            biblioteca.AgregarLibro(libro);
        }

        // Método para eliminar un libro de la biblioteca
        static void EliminarLibro()
        {
            Console.Write("Ingrese el ISBN del libro a eliminar: ");
            string isbn = Console.ReadLine();
            biblioteca.EliminarLibro(isbn);
        }

        // Método para mostrar los libros registrados en la biblioteca
        static void MostrarLibros()
        {
            biblioteca.MostrarLibros();
        }
    }
}
