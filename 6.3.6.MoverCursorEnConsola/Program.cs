using System;

class Program
{
    static void Main()
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        Console.Clear();
        Console.SetCursorPosition(x, y);

        Console.WriteLine("Usa las teclas de flecha para mover el cursor. Presiona Esc para salir.");

        while (true)
        {
            var key = Console.ReadKey(true); // Lee la tecla sin mostrarla en la consola

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (y > 0) y--; // Evitar que el cursor salga de la ventana
                    break;
                case ConsoleKey.DownArrow:
                    if (y < Console.WindowHeight - 1) y++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0) x--;
                    break;
                case ConsoleKey.RightArrow:
                    if (x < Console.WindowWidth - 1) x++;
                    break;
                case ConsoleKey.Escape: // Salir con la tecla Esc
                    return;
            }

            Console.SetCursorPosition(x, y); // Actualizar posición del cursor
        }
    }
}
