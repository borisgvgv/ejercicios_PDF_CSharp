/*
(3.1.2.1) Pregunta al usuario su edad, que se guardará en un "byte". A
continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No
aparentas 20 años").
*/ //Boris Garcés Vernier

using System;
class E3121{
    static void Main(){
        System.Console.Write("Edad: ");
        sbyte edad = Convert.ToSByte(Console.ReadLine());
        
        System.Console.WriteLine("No aparentas {0} años.", edad);
    }
}