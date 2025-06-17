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

        string texto = "";
        using (StreamWriter registroDeUsuario = new StreamWriter("registroDeUsuario.txt"))
        {
            do
            {
                Console.WriteLine("Introduce un texto");
                texto = Console.ReadLine();
                if (texto != "fin")
                {
                    registroDeUsuario.WriteLine(texto);
                    //registroDeUsuario.WriteLine();
                }

            } while (texto != "fin");

        }


        // Leer y mostrar el contenido guardado
        using (StreamReader lector = new StreamReader("registroDeUsuario.txt"))
        {
            Console.WriteLine("\nContenido del archivo:");
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
        }

/*

1. using (StreamReader lector = new StreamReader("registroDeUsuario.txt"))

    Crea un objeto StreamReader llamado lector que abre el archivo "registroDeUsuario.txt" para leer su contenido.

    El bloque using asegura que el archivo se cierre automáticamente al terminar de leer o si ocurre un error.

2. string linea;

    Declara una variable linea para almacenar cada línea leída del archivo.

3. while ((linea = lector.ReadLine()) != null)

    Lee el archivo línea por línea.

    lector.ReadLine() devuelve:

        La siguiente línea del archivo como una cadena string.

        null cuando ya no hay más líneas (final del archivo).

    El ciclo se repite mientras haya líneas por leer (es decir, mientras ReadLine() no devuelva null).

4. Console.WriteLine(linea);

    Muestra la línea leída en la consola

*/

    }
}




