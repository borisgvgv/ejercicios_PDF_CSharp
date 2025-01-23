
using System;

class Program
{
   static void Main()
   {

      Console.WriteLine("Ecribe tu nombre");
      string nombre = Console.ReadLine();
      string[] arrayanombres = { "Jesús", "María", "José" };

      foreach (char i in nombre)
      {
         Console.Write("{0} ", i);
      }

      Console.WriteLine();

      foreach (int i in nombre)
      {
         Console.Write("{0} ", i);
      }

      Console.WriteLine();

      foreach (string nombres in arrayanombres)
      {
         Console.WriteLine("{0}", nombres);
      }



   }
}
