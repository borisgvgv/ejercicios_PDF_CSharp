using System;
class E44910
{
    static void Main()
    {

        /*En ocasiones, tendremos la necesidad de crear una cadena repetitiva, formada por
        un mismo carácter varias veces. Con nuestros conocimientos actuales, podríamos
        hacerlo concatenando a partir de una cadena vacía, así:
        string asteriscos = "";
        */

        for (int i = 0; i < 10; i++)
            asteriscos += '*';

        /*
        Pero también existe la posibilidad de usar "new String", indicando el carácter que
        queremos repetir y la cantidad de veces, de esta forma:
        */
        
        string asteriscos = new String('*', 10);
        Console.WriteLine(asteriscos);
    }
}