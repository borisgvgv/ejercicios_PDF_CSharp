using System;


class Program
{

    struct myStruct
    {
        public string nombre;
        public string apellido;
        public byte edad;
    }
    static void Main()
    {

        myStruct persona = new myStruct();
        Console.WriteLine("Nombre: ");
        persona.nombre = Console.ReadLine();
        Console.WriteLine("Edad: ");
        persona.apellido = Console.ReadLine();
        Console.WriteLine("Edad: ");
        persona.edad = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("{0}, {1}, {2}", persona.nombre, persona.apellido, persona.edad);
    }
}