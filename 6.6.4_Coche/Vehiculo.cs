using System;

/*
(6.3.7) Crea un proyecto a partir de la clase Coche (ejercicio 6.2.4): además de la
clase Coche, existirá una clase PruebaDeCoche, que contendrá la función "Main",
que creará un objeto de tipo coche, pedirá al usuario su marca, modelo, cilindrada
y potencia, y luego mostrará en pantalla el valor de esos datos.
*/

/*
6.5.5) Mejora el proyecto de la clase Coche (ejercicio 6.4.5): todos los atributos
serán "protegidos" y los métodos serán "públicos".
*/

/*
(6.6.4) Mejora el proyecto de la clase Coche (ejercicio 6.5.5): añade un atributo
"cantidadDeRuedas" a la clase Vehiculo, junto con sus Get y Set. El constructor de
la clase Coche le dará el valor 4 y el constructor de la clase Moto le dará el valor 2.
*/


public class Vehiculo
{

    public static void Main()
    {

        //Console.Clear();  El Console.Clear borra los mesajes de error que produce no usar new en los nuevos metodos de las clases
    
        classCoche coche = new classCoche();
        classMoto moto = new classMoto();
        TipoDeVehiculo tipoDeVehiculo = new TipoDeVehiculo();


        System.Console.Write("Marca: ");
        string marca = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        coche.SetMarca(marca);
        coche.SetModelo(modelo);
        coche.SetCilindrada(cilindrada);
        coche.SetPotencia(potencia);
        coche.MostrarTipoDeVehiculo();
        coche.MostrarCaracteristicasDelVehiculo();
        coche.CantidadDeRuedas();


        System.Console.WriteLine();//--------------------------

        System.Console.Write("Marca: ");
        string marca2 = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo2 = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada2 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        moto.SetMarca(marca2);
        moto.SetModelo(modelo2);
        moto.SetCilindrada(cilindrada2);
        moto.SetPotencia(potencia2);
        moto.MostrarTipoDeVehiculo();
        moto.MostrarCaracteristicasDelVehiculo();
        moto.CantidadDeRuedas();

        System.Console.WriteLine();//-----------------------------


        System.Console.Write("Tipo de Vehiculo: ");
        string newTipoDeVehiculo = Console.ReadLine();
        System.Console.Write("Marca: ");
        string marca3 = Console.ReadLine();
        System.Console.Write("Modelo: ");
        string modelo3 = Console.ReadLine();
        System.Console.Write("Cilindrada: ");
        int cilindrada3 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Potencia: ");
        int potencia3 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Cantidad de ruedas: ");
        byte cantidadDeRuedas = Convert.ToByte(Console.ReadLine());


        System.Console.WriteLine();
        tipoDeVehiculo.SetTipoDeVehiculo(newTipoDeVehiculo);
        tipoDeVehiculo.SetMarca(marca3);
        tipoDeVehiculo.SetModelo(modelo3);
        tipoDeVehiculo.SetCilindrada(cilindrada3);
        tipoDeVehiculo.SetPotencia(potencia3);
        tipoDeVehiculo.SetCantidadDeRuedas(cantidadDeRuedas);
        tipoDeVehiculo.MostrarTipoDeVehiculo();
        tipoDeVehiculo.MostrarCaracteristicasDelVehiculo();
        tipoDeVehiculo.CantidadDeRuedas();


    }
}