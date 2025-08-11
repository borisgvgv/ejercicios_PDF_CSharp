/*
En C#, un fichero binario es un archivo que almacena la información en formato binario (es decir, en bytes crudos: 0s y 1s) en lugar de en texto legible como un archivo .txt o .csv.

En otras palabras:

Un archivo de texto guarda caracteres codificados (por ejemplo, usando UTF-8), y si lo abres con un editor verás letras y símbolos.

Un archivo binario guarda los datos tal cual están en memoria (números, estructuras, imágenes, etc.), sin conversión a texto, y si lo abres en un editor verás símbolos raros porque no está pensado para ser leído por personas, sino por programas.

Ventajas de los ficheros binarios
Ocupan menos espacio que los equivalentes en texto (no hay caracteres extra para representar los datos).

Lectura y escritura más rápida.

Permiten guardar datos complejos (objetos, imágenes, audio, etc.) de forma directa.

Cómo trabajar con ficheros binarios en C#
En C#, normalmente se usan clases como:

FileStream — para leer/escribir bytes directamente.

BinaryWriter — para escribir datos primitivos (int, float, string, etc.) en binario.

BinaryReader — para leer esos mismos datos.
*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "datos.bin";

        // Escribir en binario
        using (BinaryWriter writer = new BinaryWriter(File.Open(ruta, FileMode.Create)))
        {
            writer.Write(42);          // Entero
            writer.Write(3.14);        // Doble
            writer.Write("Hola");      // Cadena
        }

        // Leer en binario
        using (BinaryReader reader = new BinaryReader(File.Open(ruta, FileMode.Open)))
        {
            int numero = reader.ReadInt32();
            double decimalNum = reader.ReadDouble();
            string texto = reader.ReadString();

            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Decimal: {decimalNum}");
            Console.WriteLine($"Texto: {texto}");
        }
    }
}
