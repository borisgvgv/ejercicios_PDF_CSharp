using System;
class Program{

    static void SumaNumeros(int a, int b, string unidad){
        int resultado = a  + b;
        Console.WriteLine("{0} {1}",resultado, unidad);
    }
    static void Main(){
        Console.WriteLine("Escribe un número");
        int num1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe otro número");
        int num2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Unidad de medida");
        string unidad = Console.ReadLine();
        SumaNumeros(num1,num2, unidad);
    }
}
