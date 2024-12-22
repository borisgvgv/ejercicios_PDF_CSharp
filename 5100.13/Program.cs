using System;

class Program
{

    public static int MaximoComunDivisor(int n1, int n2)
    {
        int temp;
        int resto;

        if (n1 < n2)
        {
            temp = n2;
            n2 = n1;
            n1 = temp;
        }

        for (int i = n1 - 1; i > 0; i--)
        {
            resto = n1 % i;
            if (resto == 0)
            {
                resto = n2 % i;
                if (resto == 0)
                {
                    return i;
                }

            }
        }
        return MaximoComunDivisor(n1 - 1, n2);

    }


    public static int PedirN1()
    {
        System.Console.Write("Numero 1: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int PedirN2()
    {
        System.Console.Write("Numero 2: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void Main()
    {
        System.Console.WriteLine(MaximoComunDivisor(PedirN1(), PedirN2()));
    }
}
