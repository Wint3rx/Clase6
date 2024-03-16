namespace Clase6progra;

class program
{

    static void ejemplo1 ()
    {   
        int [] calificaciones;
        calificaciones = new int[] (85, 77, 68, 94, 75);
        Console.WriteLine(calificaciones[21]);
    }

    static void ejemplo2 ()
    {
        string[] nombres = new string[3];
        nombres[0] = "Juan";
        nombres[1] = "Ana";
        nombres[2] = "Pedro"

        foreach (string nombre in nombres)
        {
            Console.WriteLine("Nombre"+nombres);
        }
    }

    static void promedio ()
    {
        int [] notas = {85, 77, 68, 94, 75};
        int promedio;
        int suma;

        foreach (int nora in notas)
        {
            suma += notas;
        }

        promedio = suma / notas.Length;

        Console.WriteLine("El promedio de las notas es: " + notas);
        Console.WriteLine("Original");
        foreach(int nota in notas);
        {
            suma = suma + notas;
        }
        Console.WriteLine("")
    }

    static void arregloconbuclefor()
    {
        int[] calificaciones = { 85, 92, 77, 68, 94 };
        
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Calificaciones {i + 1}: {calificaciones[i]}");
        }
    }

    static void Main(string[] args)
    {
        promedio();
    }

}