using aggregation_test.Models;

namespace aggregation_test;

class Program
{
    public static void BurnedData(){
        //profesores
        AdministradorApp.Profesores.Add(new Profesor("Juan", "Gómez", "CC", "123456789", "juan.gomez@example.com", "321-555-1234", "Matemáticas", 3500.0, 15, 8, 1980));
        AdministradorApp.Profesores.Add(new Profesor("María", "Rodríguez", "TI", "987654321", "maria.rodriguez@example.com", "310-555-9876", "Literatura", 3200.0, 10, 5, 1992));
        AdministradorApp.Profesores.Add(new Profesor("Carlos", "Pérez", "CC", "543210987", "carlos.perez@example.com", "315-555-4321", "Física", 3800.0, 20, 3, 1975));
        AdministradorApp.Profesores.Add(new Profesor("Laura", "Vargas", "TI", "246813579", "laura.vargas@example.com", "317-555-2468", "Historia", 3100.0, 5, 11, 1988));
        AdministradorApp.Profesores.Add(new Profesor("Andrés", "López", "CC", "987654321", "andres.lopez@example.com", "314-555-9876", "Informática", 4000.0, 8, 2, 1983));
        //estudiantes
        AdministradorApp.Estudiantes.Add(new Estudiante("Ana", "García", "CC", "987654321", "ana.garcia@example.com", "310-555-1234", "María López", "10A", 5, 9, 2006));
        AdministradorApp.Estudiantes.Add(new Estudiante("Pedro", "Martínez", "TI", "123456789", "pedro.martinez@example.com", "315-555-9876", "Carlos Rodríguez", "11B", 12, 4, 2005));
        AdministradorApp.Estudiantes.Add(new Estudiante("Laura", "Vargas", "CC", "543210987", "laura.vargas@example.com", "317-555-2468", "María Pérez", "8C", 20, 2, 2008));
        AdministradorApp.Estudiantes.Add(new Estudiante("Carlos", "López", "TI", "135792468", "carlos.lopez@example.com", "314-555-4321", "Andrés Gómez", "9A", 8, 7, 2007));
        AdministradorApp.Estudiantes.Add(new Estudiante("María", "Rodríguez", "CC", "246813579", "maria.rodriguez@example.com", "321-555-7890", "Luisa Pérez", "12C", 3, 11, 2004));
        AdministradorApp.Estudiantes.Add(new Estudiante("Juan", "Gómez", "TI", "987654321", "juan.gomez@example.com", "310-555-5678", "Pedro Vargas", "7B", 18, 1, 2009));
        AdministradorApp.Estudiantes.Add(new Estudiante("Sofía", "Pérez", "CC", "123456789", "sofia.perez@example.com", "315-555-3456", "Ana Martínez", "10B", 22, 6, 2006));
        AdministradorApp.Estudiantes.Add(new Estudiante("Andrés", "López", "TI", "543210987", "andres.lopez@example.com", "317-555-6789", "Carlos Gómez", "11A", 10, 3, 2005));
        AdministradorApp.Estudiantes.Add(new Estudiante("Luis", "García", "CC", "135792468", "luis.garcia@example.com", "314-555-2345", "María Rodríguez", "9B", 5, 12, 2007));
        AdministradorApp.Estudiantes.Add(new Estudiante("Camila", "Martínez", "TI", "246813579", "camila.martinez@example.com", "321-555-4567", "Pedro López", "12A", 15, 8, 2004));


    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.ForegroundColor = ConsoleColor.Green; // Cambia el color del texto a verde
        Console.Write("Este texto será impreso en verde.");

        Console.ForegroundColor = ConsoleColor.Red; // Cambia el color del texto a rojo
        Console.WriteLine("Ahora este texto será impreso en rojo.");

        // Para volver al color por defecto de la consola
        Console.ResetColor();

        Console.WriteLine("Este texto será impreso en el color por defecto.");

        // Mantén la consola abierta hasta que el usuario presione una tecla
        Console.ReadKey();
    }
    public void TextoVerde(string texto){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(texto);
        Console.ResetColor();

    }
}
