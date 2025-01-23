/*
Si tenemos la necesidad de modificar una cadena letra a letra, no podemos usar
un "string" convencional, porque no es válido hacer operaciones como
texto[1]='h'; Deberíamos formar una nueva cadena en la que modificásemos
esa letra a base de unir varios substring o de borrar un fragmento con Remove y
añadir otro con Insert.
Como alternativa, podemos recurrir a los "StringBuilder", que sí lo permiten pero
son algo más complejos de manejar: hay que reservarles espacio con "new" (igual
que hacíamos en ciertas ocasiones con los Arrays), y se pueden convertir a una
cadena "convencional" usando "ToString":
*/

// Ejemplo_04_04_09a.cs
// Cadenas modificables con "StringBuilder"

using System;
using System.Text; // Usaremos un System.Text.StringBuilder
class E449_una_cadena_modificable_StringBuilder
{
    static void Main()
    {
        string saludo = "Hola";
        Console.WriteLine("Queremos modificar: {0}", saludo);
        StringBuilder cadenaModificable = new StringBuilder(saludo);
        cadenaModificable[0] = 'M';
        cadenaModificable[1] = 'u';
        Console.WriteLine("Cadena modificada: {0}", cadenaModificable);

        string cadenaNormal;
        cadenaNormal = cadenaModificable.ToString();
        Console.WriteLine("Cadena normal a partir de ella: {0}",
        cadenaNormal);
    }
}
