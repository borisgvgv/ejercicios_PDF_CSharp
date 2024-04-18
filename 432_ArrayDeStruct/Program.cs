using System;

class Program
{
    struct TipoPersona
    {
        public int numero;
        public string nombre;
        public int edad;
        public float estatura;
    }
    static void Main()
    {

        int contador = 2;
        TipoPersona[] personas = new TipoPersona[contador];
        /*
                personas[0].numero = 1;
                personas[0].nombre = "Boris";
                personas[0].edad = 46;
                personas[0].estatura = 1.78f;

                personas[1].numero = 2;
                personas[1].nombre = "Juan";
                personas[1].edad = 56;
                personas[1].estatura = 1.98f;
        */
       
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine();
            Console.Write("Número: ");
            personas[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            personas[i].nombre = Console.ReadLine();
            Console.Write("Edad: ");
            personas[i].edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Estatura: ");
            personas[i].estatura = Convert.ToSingle(Console.ReadLine());
            
        }


        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine();
            Console.Write("Persona ");
            Console.WriteLine(personas[i].numero);
            Console.WriteLine(personas[i].nombre);
            Console.WriteLine(personas[i].edad);
            Console.WriteLine(personas[i].estatura);
            Console.WriteLine("---------------------------");
            Console.WriteLine();

        }
    }
}