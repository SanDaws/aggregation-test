using aggregation_test.Models;

namespace aggregation_test;

class Program
{
    public static void BurnedData(){
        //profesores
        AdministradorApp.Profesores.Add(new Profesor("Juan", "Gómez", "CC", "123456789", "juan.gomez@example.com", "321-555-1234", "Matemáticas", 3500.0, 15, 8, 1980));
        AdministradorApp.Profesores.Add(new Profesor("María", "Rodríguez", "CC", "987654321", "maria.rodriguez@example.com", "310-555-9876", "Literatura", 3200.0, 10, 5, 1992));
        AdministradorApp.Profesores.Add(new Profesor("Carlos", "Pérez", "CC", "543210987", "carlos.perez@example.com", "315-555-4321", "Física", 3800.0, 20, 3, 1975));
        AdministradorApp.Profesores.Add(new Profesor("Laura", "Vargas", "CC", "246813579", "laura.vargas@example.com", "317-555-2468", "Historia", 3100.0, 5, 11, 1988));
        AdministradorApp.Profesores.Add(new Profesor("Andrés", "López", "CC", "987654321", "andres.lopez@example.com", "314-555-9876", "Informática", 4000.0, 8, 2, 1983));

        AdministradorApp.Profesores.Add(new Profesor("Ana", "García", "CC", "12345678A", "ana.garcia@ejemplo.com", "123456789", "Matemáticas", 2000.00, 15, 6, 2020));
        AdministradorApp.Profesores.Add(new Profesor("Luis", "Martínez", "CC", "23456789B", "luis.martinez@ejemplo.com", "987654321", "Matemáticas", 2100.00, 10, 11, 2019));

        AdministradorApp.Profesores.Add(new Profesor("María", "Lopez", "CC", "34567890C", "maria.lopez@ejemplo.com", "456789123", "Física", 2200.00, 5, 8, 2021));
        AdministradorApp.Profesores.Add(new Profesor("Pedro", "Ramírez", "CC", "45678901D", "pedro.ramirez@ejemplo.com", "321654987", "Física", 2300.00, 20, 1, 2018));

        AdministradorApp.Profesores.Add(new Profesor("Isabel", "Fernández", "CC", "56789012E", "isabel.fernandez@ejemplo.com", "654321789", "Química", 2400.00, 12, 3, 2022));
        AdministradorApp.Profesores.Add(new Profesor("Javier", "Gómez", "CC", "67890123F", "javier.gomez@ejemplo.com", "789654123", "Química", 2500.00, 7, 9, 2017));

        AdministradorApp.Profesores.Add(new Profesor("Laura", "Sánchez", "CC", "78901234G", "laura.sanchez@ejemplo.com", "321987654", "Historia", 2600.00, 18, 4, 2023));
        AdministradorApp.Profesores.Add(new Profesor("Carlos", "Hernández", "CC", "89012345H", "carlos.hernandez@ejemplo.com", "987321654", "Historia", 2700.00, 22, 7, 2019));

        AdministradorApp.Profesores.Add(new Profesor("Sofía", "Pérez", "CC", "90123456I", "sofia.perez@ejemplo.com", "456123789", "Lengua", 2800.00, 30, 10, 2020));
        AdministradorApp.Profesores.Add(new Profesor("Andrés", "Jiménez", "CC", "01234567J", "andres.jimenez@ejemplo.com", "789456123", "Lengua", 2900.00, 2, 12, 2018));

        AdministradorApp.Profesores.Add(new Profesor("Claudia", "Moreno", "CC", "12345678K", "claudia.moreno@ejemplo.com", "456789123", "Biología", 3000.00, 9, 5, 2021));
        AdministradorApp.Profesores.Add(new Profesor("David", "Cruz", "CC", "23456789L", "david.cruz@ejemplo.com", "123654789", "Biología", 3100.00, 14, 11, 2019));

        AdministradorApp.Profesores.Add(new Profesor("Paola", "Cano", "CC", "34567890M", "paola.cano@ejemplo.com", "654321987", "Informática", 3200.00, 25, 2, 2022));
        AdministradorApp.Profesores.Add(new Profesor("Miguel", "Cárdenas", "CC", "45678901N", "miguel.cardenas@ejemplo.com", "987123654", "Informática", 3300.00, 11, 6, 2017));

        AdministradorApp.Profesores.Add(new Profesor("Andrea", "Álvarez", "CC", "56789012O", "andrea.alvarez@ejemplo.com", "321789456", "Educación Física", 3400.00, 4, 9, 2020));
        AdministradorApp.Profesores.Add(new Profesor("Ricardo", "Méndez", "CC", "67890123P", "ricardo.mendez@ejemplo.com", "654321987", "Educación Física", 3500.00, 19, 1, 2018));

        Profesor.agregarCurso("11A","123456789");
        Profesor.agregarCurso("11A","987654321");
        Profesor.agregarCurso("9A","987654321");
        Profesor.agregarCurso("8C","246813579");
        Profesor.agregarCurso("7B","56789012E");
        Profesor.agregarCurso("12A","23456789L");
        Profesor.agregarCurso("12C","67890123P");
        Profesor.agregarCurso("10B","12345678K");
        Profesor.agregarCurso("10A","56789012O");

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
    static void Main()
    {
        BurnedData();
        
        Uti.MenuPrincipal();

    }
    public void TextoVerde(string texto){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(texto);
        Console.ResetColor();

    }
}
