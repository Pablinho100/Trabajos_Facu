using System;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio1: Pesos (en kg)
        Console.WriteLine("--- EJERCICIO: PESOS ---");

        double[] pesos = { 75.5, 68.2, 90.1, 55.4, 82.0 };

        int cantidad = pesos.Length;
        Console.WriteLine("El arreglo tiene " + cantidad + " elementos");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < pesos.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": Peso = " + pesos[i]);
        }

        Console.ReadLine();

        //Ejercicio2: Películas
        Console.WriteLine("--- EJERCICIO: PELÍCULAS ---");

        string[] peliculas = { "Matrix", "Inception", "Avatar", "Gladiador", "Titanic" };

        int cantidad1 = peliculas.Length;
        Console.WriteLine("El arreglo tiene " + cantidad1 + " elementos");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < peliculas.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": Película = " + peliculas[i]);
        }

        Console.ReadLine();

        //Ejercicio3: Distancias (en km)
        Console.WriteLine("--- EJERCICIO: DISTANCIAS ---");

        double[] distancias = { 12.5, 45.0, 3.2, 120.8, 8.5 };

        int cantidad2 = distancias.Length;
        Console.WriteLine("El arreglo tiene " + cantidad2 + " elementos");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < distancias.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": Distancia = " + distancias[i]);
        }

        Console.ReadLine();

        //Ejercicio4: Pisos de Edificios
        Console.WriteLine("--- EJERCICIO: PISOS DE EDIFICIOS ---");

        int[] pisos = { 10, 25, 5, 40, 15 };

        int cantidad3 = pisos.Length;
        Console.WriteLine("El arreglo tiene " + cantidad3 + " elementos");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < pisos.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": Pisos = " + pisos[i]);
        }

        Console.ReadLine();

        //Ejercicio5: Deportes
        Console.WriteLine("--- EJERCICIO: DEPORTES ---");

        string[] deportes = { "Fútbol", "Padel", "Voley", "Natación", "Rugby" };

        int cantidad4 = deportes.Length;
        Console.WriteLine("El arreglo tiene " + cantidad4 + " elementos");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < deportes.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": Deporte = " + deportes[i]);
        }

        Console.ReadLine();
    }
}
