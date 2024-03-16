namespace C_;

class Program
{
        static void ejemplo1(){
        int[]calificaciones;
        calificaciones = new int []{85,77,68,94,75};
        Console.WriteLine(calificaciones[1]);
    }

    static void ejemplo2(){
        string [] nombres = new string [3];
        nombres [0] = "Juan";
        nombres [1] = "Ana";
        nombres [2] = "Pedro";

        foreach (string nombre in nombres){
            Console.WriteLine ("Nombre="+ nombre);
        }
    }


    static void promedio (){
        int [] notas = {80,75,90,95,73,79};
        int suma=0;

        foreach (int nota in notas){
            suma = suma + nota;


        }
        Console.WriteLine("Promedio =" + (suma / 6));

        //Ahora con for
        int sumas=0;
        for (int i = 0; i < notas.Length; i++){
             sumas = suma + i;


        }
        Console.WriteLine("Promedio = "+ (sumas / 6 ));

        bool HayAprobados = Array.Exists(notas, calif => calif >=60);
        Console.WriteLine(HayAprobados);

        
    }
    static void Main(string[] args)
    {
        promedio();
    }
}
