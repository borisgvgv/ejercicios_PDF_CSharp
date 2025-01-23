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


        int resto;
        if (n == 2 || n == 3 || n == 5 || n == 7)
        {
            primo = true;
        }
        else if ((resto = n % 2) == 0 || (resto = n % 3) == 0 || (resto = n % 5) == 0 || (resto = n % 7) == 0)
        {
            primo = false;
        }

        return primo;

    }
    static void Main()
    {
        System.Console.WriteLine(CalcularPrimo(PedirNumero()));
    }
}
