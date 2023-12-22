// Ejemplo_05_06_13a.cs
// Uso de "TryParse"
// Introducción a C#, por Nacho Cabanes
using System;
class ParseNums
{
    static void Main()
    {
      
            int a;
            
            // Planteamiento con try-catch
            Console.Write("Introduce un entero: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Su valor es {0}", a);
            }
            catch (Exception)
            {
                Console.WriteLine("No es un número válido");
            }

            // Alternativa con TryParse
            Console.Write("Introduce otro entero: ");
            if (Int32.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Su valor es {0}", a);
            else
                Console.WriteLine("No es un número válido");

//------------------------------------------------------------------

               

        // Intentar convertir la cadena a un entero usando TryParse
         string input = "123";
        if (int.TryParse(input, out int result))
        {
            // La conversión fue exitosa, 'result' contiene el valor convertido
            Console.WriteLine("Conversión exitosa. Valor convertido: " + result);
        }
        else
        {
            // La conversión falló
            Console.WriteLine("La conversión falló. La cadena no representa un número entero válido.");
        }

        }

    }
