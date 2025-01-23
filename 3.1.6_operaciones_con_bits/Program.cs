using System;
class E316
{
    static void Main()
    {

        int a = 67;
        int b = 70;
        int numero = 0;

        Console.WriteLine("La variable a vale {0}", a);
        Console.WriteLine("y b vale {0}", b);
        Console.WriteLine(" El complemento de a es: {0}", ~a);
        Console.WriteLine(" El producto lógico de a y b es: {0}", a & b);
        Console.WriteLine(" Su suma lógica es: {0}", a | b);
        Console.WriteLine(" Su suma lógica exclusiva es: {0}", a ^ b);
        Console.WriteLine(" Desplacemos a a la izquierda: {0}", a << 1);
        Console.WriteLine(" Desplacemos a a la derecha: {0}", a >> 1);


        Console.WriteLine(Convert.ToString(a, 2));
        a = ~a;
        a = a--;
        Console.WriteLine(Convert.ToString(a, 8));
        numero = Convert.ToInt32("45", 2);
        Console.WriteLine(numero);

        


    }
}