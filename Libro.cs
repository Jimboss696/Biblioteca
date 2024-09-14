using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // Clase Libro que define las propiedades de un libro
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }  // Nueva propiedad para el género del libro

        // Constructor que inicializa un libro con su título, autor, ISBN y género
        public Libro(string titulo, string autor, string isbn, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Genero = genero;  // Asignación del género
        }

        // Método que muestra la información del libro en la consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Género: {Genero}");
        }
    }
}
