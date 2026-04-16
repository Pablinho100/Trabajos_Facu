using System;
class Program
{
    static void Main(string[] args)
    {
        // Ejercicio1: Notas de Alumnos
        Console.WriteLine("--- EJERCICIO: NOTAS DE ALUMNOS ---");

        int[] notasAlumnos = new int[3];

        notasAlumnos[0] = 8;
        notasAlumnos[1] = 10;
        notasAlumnos[2] = 5;

        Console.WriteLine("Nota 1: " + notasAlumnos[0]);
        Console.WriteLine("Nota 2: " + notasAlumnos[1]);
        Console.WriteLine("Nota 3: " + notasAlumnos[2]);

        Console.ReadLine();

        // Ejercicio2: Temperaturas
        Console.WriteLine("--- EJERCICIO: TEMPERATURAS ---");

        double[] temperaturas = new double[3];

        temperaturas[0] = 25.5;
        temperaturas[1] = 31.2;
        temperaturas[2] = 14.8;

        Console.WriteLine("Temperatura 1: " + temperaturas[0] + " grados");
        Console.WriteLine("Temperatura 2: " + temperaturas[1] + " grados");
        Console.WriteLine("Temperatura 3: " + temperaturas[2] + " grados");

        Console.ReadLine();

        // Ejercicio3: Mascotas
        Console.WriteLine("--- EJERCICIO: MASCOTAS ---");

        string[] mascotas = new string[3];

        mascotas[0] = "Perro";
        mascotas[1] = "Gato";
        mascotas[2] = "Loro";

        Console.WriteLine("Mascota 1: " + mascotas[0]);
        Console.WriteLine("Mascota 2: " + mascotas[1]);
        Console.WriteLine("Mascota 3: " + mascotas[2]);

        Console.ReadLine();

        // Ejercicio4: Stock de Productos
        Console.WriteLine("--- EJERCICIO: STOCK DE PRODUCTOS ---");

        int[] stock = new int[3];

        stock[0] = 150;
        stock[1] = 25;
        stock[2] = 0;

        Console.WriteLine("Stock producto 1: " + stock[0] + " unidades");
        Console.WriteLine("Stock producto 2: " + stock[1] + " unidades");
        Console.WriteLine("Stock producto 3: " + stock[2] + " unidades");

        Console.ReadLine();

        // Ejercicio5: Profesiones
        Console.WriteLine("--- EJERCICIO: PROFESIONES ---");

        string[] profesiones = new string[3];

        profesiones[0] = "Programador";
        profesiones[1] = "Médico";
        profesiones[2] = "Arquitecto";

        Console.WriteLine("Profesión 1: " + profesiones[0]);
        Console.WriteLine("Profesión 2: " + profesiones[1]);
        Console.WriteLine("Profesión 3: " + profesiones[2]);

        Console.ReadLine();
    }

}
