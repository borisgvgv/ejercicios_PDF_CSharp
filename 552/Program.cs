/*
5.5.2) Crea una función "EscribirTablaMultiplicar", que reciba como parámetro un
número entero, y escriba la tabla de multiplicar de ese número (por ejemplo, para
el 3 deberá llegar desde "3x0=0" hasta "3x10=30").
*/

using System;
class Program{
    static void EscribirTablaMultiplicar(int numero){
        for(int i=1; i<=10; i++){
            Console.WriteLine("{0}*{1}={2}", numero, i, numero * i);
        }
    }
    static void Main(){
        
        Console.WriteLine("Introduce un número para escribir su tabla de multiplicar de 0 a 10");
        int numero = Convert.ToInt32(Console.ReadLine());
        EscribirTablaMultiplicar(numero);

    }
}