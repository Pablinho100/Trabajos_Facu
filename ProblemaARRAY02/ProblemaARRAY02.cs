using System;

class Program
{
    static void Main(string[] args)
    {

        // Ejercicio1: Frutas
        Console.WriteLine("--- EJERCICIO: FRUTAS ---");

        string[] frutas = { "Manzana", "Banana", "Naranja", "Pera" };

        Console.WriteLine("Lista de frutas:");

        foreach (string fruta in frutas)
        {
            Console.WriteLine("- " + fruta);
        }

        Console.ReadLine();


        // Ejercicio2: Marcas de Autos
        Console.WriteLine("--- EJERCICIO: MARCAS DE AUTOS ---");

        string[] marcasAutos = { "Ford", "Chevrolet", "Toyota", "Fiat" };

        Console.WriteLine("Lista de marcas de autos:");

        foreach (string marca in marcasAutos)
        {
            Console.WriteLine("- " + marca);
        }

        Console.ReadLine();

        // Ejercicio3: Instrumentos Musicales
        Console.WriteLine("--- EJERCICIO: INSTRUMENTOS MUSICALES ---");

        string[] instrumentos = { "Guitarra", "Piano", "Batería", "Flauta" };

        Console.WriteLine("Lista de instrumentos musicales:");

        foreach (string instrumento in instrumentos)
        {
            Console.WriteLine("- " + instrumento);
        }

        Console.ReadLine();

        // Ejercicio4: Años de Mundiales
        Console.WriteLine("--- EJERCICIO: AÑOS DE MUNDIALES ---");

        int[] aniosMundiales = { 2006, 2010, 2014, 2018, 2022 };

        Console.WriteLine("Lista de años de mundiales recientes:");

        foreach (int anio in aniosMundiales)
        {
            Console.WriteLine("- " + anio);
        }

        Console.ReadLine();

        // Ejercicio5: Lenguajes de Programación
        Console.WriteLine("--- EJERCICIO: LENGUAJES DE PROGRAMACIÓN ---");

        string[] lenguajes = { "C#", "Java", "Python", "JavaScript" };

        Console.WriteLine("Lista de lenguajes de programación:");

        foreach (string lenguaje in lenguajes)
        {
            Console.WriteLine("- " + lenguaje);
        }

        Console.ReadLine();

    }

}

