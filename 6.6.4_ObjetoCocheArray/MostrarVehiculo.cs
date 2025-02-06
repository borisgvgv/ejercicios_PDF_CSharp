using System;

public class MostrarVehiculo
{
    public static void Main()
    {
        Console.Clear();
        int cantidad = 0, capacidad = 1000;
        bool salir = false;
        byte opcion;

        TipoDeVehiculo[] tipoDeVehiculo = new TipoDeVehiculo[capacidad];

        do
        {

            System.Console.WriteLine("1: Add datos");
            System.Console.WriteLine("2: Mostrar vehículo");
            System.Console.WriteLine("0: Salir");

            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidad < capacidad)
                    {
                        tipoDeVehiculo[cantidad] = new TipoDeVehiculo();

                        System.Console.Write("Tipo de coche: ");
                        string newTipoDeVehiculo = Console.ReadLine();
                        System.Console.Write("Marca: ");
                        string marca = Console.ReadLine();
                        System.Console.Write("Modelo: ");
                        string modelo = Console.ReadLine();
                        System.Console.Write("Cilindrada: ");
                        int cilindrada = Convert.ToInt32(Console.ReadLine());


                        tipoDeVehiculo[cantidad].SetMarca(marca);
                        tipoDeVehiculo[cantidad].SetModelo(modelo);
                        tipoDeVehiculo[cantidad].SetCilindrada(cilindrada);
                        tipoDeVehiculo[cantidad].SetTipoDeVehiculo(newTipoDeVehiculo);
                        cantidad++;
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("No se pueden añadir más datos");
                    }
                    break;

                case 2:
                    for (int i = 0; i < cantidad; i++)
                    {
                        tipoDeVehiculo[i].MostrarTipoDeVehiculo();
                        tipoDeVehiculo[i].MostrarCaracteristicasDelVehiculo();
                        System.Console.WriteLine();
                    }

                    break;

                case 0:
                    salir = true;
                    break;

                default:
                    System.Console.WriteLine("Opcion incorrecta");
                    System.Console.WriteLine("Vuelve as intentarlo");
                    break;
            }


        } while (!salir);



    }
}
