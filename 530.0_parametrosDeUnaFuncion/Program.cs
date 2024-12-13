using System;

class Program
{

    public static void EscribirNumeroReal(float n)
    {
        System.Console.WriteLine("Sin modificar: {0}", n);
        System.Console.WriteLine("Con Convert.ToDouble: {0}", Convert.ToDouble(n));
        System.Console.WriteLine("Con Convert.ToSingle: {0}", Convert.ToSingle(n));
        System.Console.WriteLine("Con n.ToString: {0}", n.ToString("#.##"));

    }

    static void Main()
    {
        EscribirNumeroReal(2.3f);
    }
}