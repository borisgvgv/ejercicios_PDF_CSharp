
using System;
class Prueba
{
    static void Main()
    {
        //Forma correcta de armar un array de datos conocidos y mostrarlos 
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + ", ");

        Console.WriteLine();//Salto de línea.

        //Forma correcta de armar un array de datos desconocidos y mostrarlos 
        int[] array2 = new int[5];
        //Damos valor a cada espaciodel array partiendo de cero
        array2[0] = 66;
        array2[1] = 77;
        array2[2] = 88;
        array2[3] = 99;
        array2[4] = 100;
        for (int i = 0; i < array2.Length; i++)
            Console.Write(array2[i] + ", ");
    }
}