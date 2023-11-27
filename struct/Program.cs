// Ejemplo_04_03_01a.cs
// Registros (struct)
// Introducción a C#, por Nacho Cabanes


using System;
class Ejemplo_04_03_01a
{
    // Se declarar cual va a ser la estructura interna del registro antes del Main
    struct tipoPersona
    {
        public string nombre;
        public char inicial;
        public int edad;
        public float nota;
    }
    struct tipoSer
    {
        public string tipo;
        public string nombre;
        public char inicial;
        public int edad;
    }

    static void Main()
    {
        tipoPersona persona;
        persona.nombre = "Juan";
        persona.inicial = 'J';
        persona.edad = 20;
        persona.nota = 7.5f;
        Console.WriteLine("La edad de {0} es {1}",
        persona.nombre, persona.edad);

        tipoPersona persona2;
        persona2.nombre = "Pedro";
        persona2.inicial = 'P';
        persona2.edad = 30;
        persona2.nota = 8.5f;
        Console.WriteLine("La edad de {0} es {1}, su nota es {2}",
        persona2.nombre, persona2.edad, persona2.nota);


        Console.WriteLine(); //Salto

        tipoSer[] ser = new tipoSer[2];
        ser[0].tipo = "Gato";
        ser[0].nombre = "Bigotes";
        ser[0].edad = 3;
        ser[0].inicial = 'B';
        Console.WriteLine("El {0} se llama {1} tiene {2} años y su le llamamos {3}", ser[0].tipo, ser[0].nombre, ser[0].edad, ser[0].inicial);

        ser[1].tipo = "Perro";
        ser[1].nombre = "Sultán";
        ser[1].edad = 5;
        ser[1].inicial = 'S';
        Console.WriteLine("El {0} se llama {1} tiene {2} años y su le llamamos {3}", ser[1].tipo, ser[1].nombre, ser[1].edad, ser[1].inicial);




    }
}