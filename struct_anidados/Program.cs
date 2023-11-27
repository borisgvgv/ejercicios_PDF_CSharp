/*
4.3.3. structs anidados
Podemos encontrarnos con un registro que tenga varios datos, y que a su vez
ocurra que uno de esos datos esté formado por varios datos más sencillos. Es lo
que se conoce como un "struct anidado". Por ejemplo, una fecha de nacimiento
podría estar formada por día, mes y año. Para hacerlo desde C#, incluiríamos un
"struct" en la definición del de otro, así:
// Ejemplo_04_03_03a.cs
// Registros anidados
// Introducción a C#, por Nacho Cabanes
*/

using System;
class Ejemplo_04_03_03a
{
    struct fechaNacimiento
    {
        public byte dia;
        public byte mes;
        public short anyo;
    }
    struct tipoPersona
    {
        public string nombre;
        public char inicial;
        public fechaNacimiento diaDeNacimiento;
        public float nota;
    }
    static void Main()
    {
        tipoPersona persona;
        persona.nombre = "Juan";
        persona.inicial = 'J';
        persona.diaDeNacimiento.dia = 15;
        persona.diaDeNacimiento.mes = 9;
        persona.nota = 7.5f;
        Console.WriteLine("{0} nació en el mes {1}",
        persona.nombre, persona.diaDeNacimiento.mes);
    }
}