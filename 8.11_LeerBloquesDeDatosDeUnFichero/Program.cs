/*
Leer byte a byte puede ser cómodo, pero también es lento. Por eso, en la práctica
es más habitual leer grandes bloques de datos. Típicamente, esos datos se
guardarán como un array de bytes.
Para eso, dentro de la clase "FileStream" tenemos método "Read", que nos
permite leer una cierta cantidad de datos desde el fichero. Le indicaremos en qué
array guardar esos datos, a partir de qué posición del array debe introducir los
datos (no la posición en el fichero, sino en el array, de modo que casi siempre será
0, es decir, al principio del array), y qué cantidad de datos se deben leer. Nos
devuelve un valor, que es la cantidad de datos que se han podido leer realmente
(porque puede ser menos de lo que le hemos pedido, si hay un error de lectura o
si hemos llegado al final del fichero)
*/

using System;
using System.IO;

public class Ejemplo_08_11a
{
    public static void Main()
    {
        Console.WriteLine("Introduzca el nombre del fichero:");
        string nombreArchivo = Console.ReadLine();

        if (!File.Exists(nombreArchivo))
        {
            Console.WriteLine("El fichero no existe.");
            bool salir = false;
            do
            {
                Console.WriteLine("Quieres crearlo Y/N ");
                char opcion = Convert.ToChar(Console.ReadLine());
                if (opcion == 'y')
                {
                    Console.WriteLine("Indica el formato de tu archivo");
                    string formato = Console.ReadLine();
                    nombreArchivo = nombreArchivo.ToLower() + formato;

                    using (BinaryWriter archivoBinario = new BinaryWriter(File.Open(nombreArchivo, FileMode.Create)))
                    {
                        Console.WriteLine("Añade contenido a tu archivo o añade fin para terminar");

                        string contenido;
                        do
                        {
                            contenido = Console.ReadLine();
                            if (contenido != "fin")
                                archivoBinario.Write(contenido);
                        } while (contenido != "fin");

                    }
                    salir = true;
                }
                else if (opcion == 'n')
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opción incorecta");
                }
            } while (!salir);


        }

        try
        {
            using (FileStream fichero = File.OpenRead(nombreArchivo))
            {
                byte[] datos = new byte[10];
                int cantidadLeida = fichero.Read(datos, 0, datos.Length);

                if (cantidadLeida < 10)
                    Console.WriteLine("No se han podido leer todos los datos!");
                else
                {
                    Console.WriteLine("El primer byte leído es {0}", datos[0]);
                    Console.WriteLine("El tercero es {0}", datos[2]);
                    
                    /*
                    El archivo que estás leyendo parece ser binario 
                    (probablemente un ejecutable o similar) — de hecho, 
                    las primeras dos letras "MZ" son típicas de archivos 
                    .exe en Windows.

                    Pero aquí el truco:

                    En binario, "M" no es lo primero que ves en memoria 
                    si el archivo tiene algún byte de control antes.
                    El valor 2 que te aparece es el byte real en la posición 0 del archivo,
                    y 2 en decimal corresponde a 0x02 en hexadecimal. Este byte no es un carácter
                     imprimible, es un carácter de control ASCII llamado "Start of Text" (STX)
                    El hecho de que en un editor de texto veas "MZ" no significa que literalmente
                     en la posición cero haya una M; algunos editores saltan bytes de control o te muestran 
                     la parte interpretada como texto.
                    */
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error de E/S: " + ex.Message);
        }
    }
}


