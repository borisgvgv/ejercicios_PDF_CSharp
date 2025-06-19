/*
(8.1.1) Crea un programa que vaya leyendo las frases que el usuario teclea y las
guarde en un fichero de texto llamado "registroDeUsuario.txt". Terminará cuando
la frase introducida sea "fin" (esa frase no deberá guardarse en el fichero).
*/


/*
- Abre el archivo "registroDeUsuario.txt" una sola vez.

- Lee frases del usuario en un bucle.

- Cuando la frase sea distinta de "fin", la escribe en el archivo.

- Si la frase es "fin", termina sin guardar esa línea.

- Cierra el archivo al final.
*/

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        CrearFicha ficha = new CrearFicha();
        ficha.MostrarEstado();
        LeerFicha leer = new LeerFicha();
        leer.MostrarEstado();

    }

}



