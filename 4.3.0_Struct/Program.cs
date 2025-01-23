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
        // Creamos una persona como una variable de TipoPersona
        TipoPersona persona1, persona2;

        persona1.numero = 1;
        persona1.nombre = "Boris";
        persona1.edad = 46;
        persona1.estatura = 1.78f;

        persona2.numero = 2;
        persona2.nombre = "Juan";
        persona2.edad = 56;
        persona2.estatura = 1.98f;

        Console.WriteLine();
        Console.WriteLine("Persona {0}: Nombre : {1}, Edad: {2}, Estatura: {3}", persona1.numero, persona1.nombre, persona1.edad, persona1.estatura);
        Console.WriteLine("Persona {0}: Nombre : {1}, Edad: {2}, Estatura: {3}", persona2.numero, persona2.nombre, persona2.edad, persona2.estatura);
        Console.WriteLine();
    }
}
