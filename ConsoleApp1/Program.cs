// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using ConsoleApp1;

// Crear un libro de ejemplo
var libro = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967, true);
Console.WriteLine(libro.ToString());

// Crear el fichero respuestas.txt con las respuestas pedidas
string respuestas = "a) El símbolo '-' delante de los atributos indica que son privados (no accesibles desde fuera de la clase).\n" +
                    "   El símbolo '+' delante de los métodos indica que son públicos (accesibles desde fuera de la clase).\n" +
                    "b) El tipo de dato disponible es 'bool' y puede tener dos valores: true o false.\n" +
                    "c) El método ToString() sirve para devolver una representación en forma de cadena del objeto,\n" +
                    "   normalmente con información relevante sobre sus atributos.\n";

File.WriteAllText("respuestas.txt", respuestas);
Console.WriteLine("Fichero 'respuestas.txt' creado.");
