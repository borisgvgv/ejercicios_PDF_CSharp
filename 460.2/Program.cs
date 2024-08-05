using System;

class Program
{
    struct myStruct
    {
        public string nombre;
        public byte diaDeNacimiento;
        public byte mesDeNacimiento;
        public int anyoDeNacimiento;
    }

    static void Main()
    {
        byte capacidad = 8;
        byte cantidad = 0;
        byte opcion;
        byte mesBuscar;
        bool salir = false;

        myStruct[] datosPersona = new myStruct[capacidad];

        do
        {
            Console.WriteLine();
            Console.WriteLine("Menú");
            Console.WriteLine("1 - Add datos");
            Console.WriteLine("2 - Mostrar todos los datos según mes de nacimiento");
            Console.WriteLine("0 - Salir");

            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    if (cantidad < capacidad)
                    {
                        Console.WriteLine("Nombre: ");
                        datosPersona[cantidad].nombre = Console.ReadLine();
                        Console.WriteLine("Dia de nacimiento: ");
                        datosPersona[cantidad].diaDeNacimiento = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Mes de nacimiento: ");
                        datosPersona[cantidad].mesDeNacimiento = Convert.ToByte(Console.ReadLine());
                        if (datosPersona[cantidad].mesDeNacimiento == 0)
                        {
                            salir = true;
                        }
                        Console.WriteLine("Año de nacimiento: ");
                        datosPersona[cantidad].anyoDeNacimiento = Convert.ToInt32(Console.ReadLine());

                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No es posible añadir más datos");
                        Console.WriteLine("Elije otra opción");
                    }

                    break;

                case 2:

                    Console.WriteLine("Qué mes quieres mostrar?: ");
                    mesBuscar = Convert.ToByte(Console.ReadLine());

                    for (byte i = 0; i < cantidad; i++)
                    {
                        if (mesBuscar == datosPersona[i].mesDeNacimiento)
                        {
                            Console.WriteLine("datos {0}", i + 1);
                            Console.WriteLine("Dia de nacimiento: {0}", datosPersona[i].diaDeNacimiento);
                            Console.WriteLine("Mes de nacimiento: {0}", datosPersona[i].mesDeNacimiento);
                            Console.WriteLine("Año de nacimiento: {0}", datosPersona[i].anyoDeNacimiento);
                        }
                    }

                    break;

                case 0:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("Inténtalo denuevo");
                    break;
            }



        } while (!salir);




    }
}
