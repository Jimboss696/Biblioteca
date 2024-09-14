using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // Clase Biblioteca que representa una colección de libros
    class Biblioteca
    {
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }

        // Constructor que inicializa una biblioteca con su nombre y una lista vacía de libros
        public Biblioteca(string nombre)
        {
            Nombre = nombre;
            Libros = new List<Libro>();
        }

        // Método para agregar un libro a la biblioteca
        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"Libro {libro.Titulo} agregado a la biblioteca {Nombre}.");
        }

        // Método para eliminar un libro de la biblioteca por su ISBN
        public void EliminarLibro(string isbn)
        {
            Libro libroAEliminar = Libros.Find(l => l.ISBN == isbn);
            if (libroAEliminar != null)
            {
                Libros.Remove(libroAEliminar);
                Console.WriteLine($"Libro con ISBN {isbn} eliminado de la biblioteca {Nombre}.");
            }
            else
            {
                Console.WriteLine($"Libro con ISBN {isbn} no encontrado en la biblioteca {Nombre}.");
            }
        }

        // Método que muestra la lista de libros de la biblioteca
        public void MostrarLibros()
        {
            Console.WriteLine($"Biblioteca: {Nombre}");
            if (Libros.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
            }
            else
            {
                foreach (var libro in Libros)
                {
                    libro.MostrarInformacion();
                }
            }
        }
    }
}
