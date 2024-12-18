using System;

class Program
{

    public static int PedirNumero()
    {
        System.Console.Write("Numero: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static bool CalcularPrimo(int n)
    {
        bool primo = true;

        if (n == 1)
            primo = false;
            
        for (int i = 2; i < n; i++)
        {
                int resto = n % 2;

                if (resto == 0)
                {
                    primo = false;
                }
            }


        return primo;

    }
    static void Main()
    {
        System.Console.WriteLine(CalcularPrimo(PedirNumero()));
    }
}
