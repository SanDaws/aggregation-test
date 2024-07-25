namespace aggregation_test;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.ForegroundColor = ConsoleColor.Green; // Cambia el color del texto a verde
        Console.WriteLine("Este texto será impreso en verde.");

        Console.ForegroundColor = ConsoleColor.Red; // Cambia el color del texto a rojo
        Console.WriteLine("Ahora este texto será impreso en rojo.");

        // Para volver al color por defecto de la consola
        Console.ResetColor();

        Console.WriteLine("Este texto será impreso en el color por defecto.");

        // Mantén la consola abierta hasta que el usuario presione una tecla
        Console.ReadKey();
    }
}
