/*
(5.4.1) Crea una función "Cubo" que calcule el cubo de un número real (float) que
se indique como parámetro. El resultado deberá ser otro número real. Prueba esta
función para calcular el cubo de 3.2 y el de 5
*/

using System;
class Program{
    static  float Cubo(float num){
        return num * num * num;
    }
    static void Main(){
        Console.WriteLine("Introduce un número real y hallaremos el Cubo");
        float num = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine(Cubo(num));
        Console.WriteLine("El mismo resultado con dos decimales sería {0}", Cubo(num).ToString("#.##"));

    }
}