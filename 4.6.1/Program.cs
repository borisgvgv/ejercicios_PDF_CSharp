using System;


class Program
{

    struct myStruct
    {
        public string nombre;
        public string apellidos;
        public byte edad;
    }

    static void Main()
    {

        myStruct persona = new myStruct();

        Console.WriteLine("Nombre: ");
        persona.nombre = Console.ReadLine();
        Console.WriteLine("Apellidos: ");
        persona.apellidos = Console.ReadLine();
        Console.WriteLine("Edad: ");
        persona.edad = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("{0}, {1}, {2}", persona.nombre, persona.apellidos, persona.edad);
    }
}