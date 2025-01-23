/*
Crea una función "Distancia", que calcule la distancia entre dos puntos
(x1,y1) y (x2,y2), usando la expresión d = raíz [ (x1-x2)2 + (y1-y2)2 ].*/
using System;

class Program {
  public static double Distancia(double x1, double y1, double x2, double y2){
    //d = raíz [ (x1-x2)2 + (y1-y2)2 ]

   double d = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
   return d;
   
  }
  public static void Main (string[] args) {

    double x1 = 8, x2 = 7, y1 = 6, y2 = 5;;
    Console.WriteLine ((Distancia(x1,x2,y1,y2)).ToString("#.##"));
    
  }
}