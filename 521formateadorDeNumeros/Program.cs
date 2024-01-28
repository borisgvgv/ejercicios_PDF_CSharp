using System;
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Escribe un número");
        float numero = Convert.ToSingle(Console.ReadLine());
        FormateadorNum(numero);
    }

    static void FormateadorNum(float numero){
        
         Console.WriteLine(numero.ToString("#.###"));
    }
 
}