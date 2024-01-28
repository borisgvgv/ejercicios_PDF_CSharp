using System;
class Program
{
    static void Duplicar(int x)
    {
        Console.WriteLine(" * El valor recibido vale {0}", x);
        x = x * 2;
        Console.WriteLine(" * y ahora vale {0}", x);
    }
    static void Main()
    {
        int n = 5;
        Console.WriteLine("n vale {0}", n);
        Duplicar(n);
        Console.WriteLine("Ahora n vale {0}", n);
    }

}
