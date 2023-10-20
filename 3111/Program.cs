/*
(3.1.1.1) Calcula el producto de 1.000.000 por 1.000.000, usando una variable
llamada "producto", de tipo "long". Prueba también a calcularlo usando una
variable de tipo "int".
*/

using System;
class E3111
{
    static void Main()
    {

       long producto = 1.000.000;

        producto = producto * producto;
        Console.WriteLine(producto);

    }
}
