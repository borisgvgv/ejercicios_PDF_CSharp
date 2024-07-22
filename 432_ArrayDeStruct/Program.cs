using System;

class Program
{


    struct fechaNacimiento
    {
        public byte dia;
        public byte mes;
        public int anyo;
    }
    struct TipoPersona
    {
        public string nombre;
        public fechaNacimiento cumpleanyo;
        public float estatura;
    }
    static void Main()
    {

        byte option;
        int i;
        int numPersona = 0;
        bool salir = true;
        TipoPersona[] personas = new TipoPersona[3];

        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine("1- Add nueva persona");
            Console.WriteLine("2 - Mostrar personas");
            Console.WriteLine("3 - Salir");

            option = Convert.ToByte(Console.ReadLine());


            switch (option)
            {
                case 1:

                    if (numPersona == 3 && option == 1)
                    {

                        Console.WriteLine("No se pueden añadir más datos");
                        Console.WriteLine("Elige otra opción del menú");


                    }
                    else
                    {

                        Console.WriteLine("Nombre: ");
                        personas[numPersona].nombre = Console.ReadLine();
                        Console.WriteLine("Día de nacimiento: ");
                        personas[numPersona].cumpleanyo.dia = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Mes de nacimiento: ");
                        personas[numPersona].cumpleanyo.mes = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Año de nacimiento: ");
                        personas[numPersona].cumpleanyo.anyo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Estatura: ");
                        personas[numPersona].estatura = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine();
                        numPersona++;

                    }


                    salir = false;

                    break;
                case 2:
                    for (i = 0; i < numPersona; i++)
                    {
                        Console.WriteLine("Persona: {0}", i + 1);
                        Console.WriteLine("Nombre: {0}", personas[i].nombre);
                        Console.WriteLine("Cumpleaño: {0}/{1}/{2}", personas[i].cumpleanyo.dia, personas[i].cumpleanyo.mes, personas[i].cumpleanyo.anyo);
                        Console.WriteLine("Edad : {0}", 2024 - personas[i].cumpleanyo.anyo );
                        Console.WriteLine("Estatura: {0} m", personas[i].estatura);

                        Console.WriteLine();//salto de línea.
                    }
                    salir = false;
                    break;

                case 3:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("Vuelve a intentarlo");

                    salir = false;
                    break;
            }


        } while (!salir);

        Console.WriteLine("Fin");




    }
}