using System;
using System.Collections.Generic;

class Application
{
    static List<string> alumnos = new List<string>();
    static List<double> notas = new List<double>();

    static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de gestión de alumnos.");
        bool terminar = false;
        while (!terminar)
        {
            Console.WriteLine("\n1. Añadir alumno");
            Console.WriteLine("2. Mostrar lista de alumnos");
            Console.WriteLine("3. Calcular media de notas");
            Console.WriteLine("4. Mostrar alumno con la nota más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int eleccion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (eleccion)
            {
                case 1:
                    AñadirAlumno();
                    break;
                case 2:
                    MostrarAlumnos();
                    break;
                case 3:
                    CalcularMedia();
                    break;
                case 4:
                    MostrarAlumnoConMaxNota();
                    break;
                case 5:
                    terminar = true;
                    Console.WriteLine("Saliendo del Programa");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void AñadirAlumno()
    {
        string nombre;
        double nota;

        Console.Write("Ingrese el nombre del alumno: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la nota del alumno: ");
        while (!double.TryParse(Console.ReadLine(), out nota))
        {
            Console.WriteLine("Entrada no valida Ingrese un numero.");
            Console.Write("Ingrese la nota del alumno: ");
        }
        alumnos.Add(nombre);
        notas.Add(nota);
        Console.WriteLine("Alumno añadido correctamente.");
    }
    static void MostrarAlumnos()
    {
        if (alumnos.Count == 0)
        {
            Console.WriteLine("No hay alumnos registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de alumnos:");
            for (int i = 0; i < alumnos.Count; i++)
            {
                Console.WriteLine($"{alumnos[i]} - Nota: {notas[i]}");
            }
        }
    }
    static void CalcularMedia()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas registradas.");
        }
        else
        {
            double total = 0;
            foreach (double nota in notas)
            {
                total += nota;
            }
            double media = total / notas.Count;
            Console.WriteLine($"La media de notas es: {media}");
        }
    }
    static void MostrarAlumnoConMaxNota()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas registradas.");
        }
        else
        {
            double notaMaxima = notas[0];
            string alumnoMaximo = alumnos[0];
            for (int i = 1; i < notas.Count; i++)
            {
                if (notas[i] > notaMaxima)
                {
                    notaMaxima = notas[i];
                    alumnoMaximo = alumnos[i];
                }
            }
            Console.WriteLine($"El alumno con la nota más alta es: {alumnoMaximo} con {notaMaxima}");
        }
    }
}