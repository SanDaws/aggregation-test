using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;
    public static class Uti
    {
        public static void TextoVerde(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Console.ResetColor();

        }
        // textos desplegados en rojo
        public static void TextoRojo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(texto);
            Console.ResetColor();

        }
//menu principal
        public static void MenuPrincipal(){
            Title("AdministracionColegio",ConsoleColor.Magenta);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Estudiantes
        2: Profesores
        0: Salir");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://hacia menu estudiantes
                    MenuEstudiantes();
                    break;
                case ConsoleKey.D2:// hacia menu Profesores
                    Menuprofesores();
                    break;
                case ConsoleKey.D0:// Salida

                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    MenuPrincipal();

                    break;
            }
        }
        public static void MenuEstudiantes(){
            Title("Estudiantes",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista de estudiantes
        2: Nuevo registro Estudiante
        3: eliminar registro Estudiante
        4: Promedio Del Estudiante
        0: Salir");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    ListarEstudiantes(AdministradorApp.Estudiantes,"Todos los Estudiantes");
                    break;
                case ConsoleKey.D2:// case employe menu
                    NuevoEstudiante();
                    break;
                case ConsoleKey.D3:// case customer menu
                    AdministradorApp.RemoverEstudiante();
                    break;
                    case ConsoleKey.D4:// proimedio estudiante
                   
                    break;
                case ConsoleKey.D0:// case exit

                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    MenuEstudiantes();
                    break;
            }
        }
        public static void Menuprofesores(){
            Title("Profesores",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista De Profesores
        2: Nuevo Registro Profesor
        3: eliminar Registro de Profesor
        4: Salario Profesor
        0: Salir");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    ListarProfesores(AdministradorApp.Profesores,"Todos los profesores");
                    break;
                case ConsoleKey.D2:// case employe menu
                    NuevoProfesor();
                    break;
                case ConsoleKey.D3:// case customer menu
                    AdministradorApp.RemoverProfesor();
                    break;
                case ConsoleKey.D4:// proimedio estudiante
                   AdministradorApp.SalarioProfesor();
                    break;
                case ConsoleKey.D0:// case exit

                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    Menuprofesores();

                    break;
            }
        }


        //Titulos
        public static void Title(string title,ConsoleColor color){
            Console.Clear();
            Console.ForegroundColor = color;
            string upperline = new string('═', Console.WindowWidth - 2);
            Console.WriteLine("╔" + upperline + "╗");
            string midelLine = new string(' ', (Console.WindowWidth / 2) - title.Length/2);
            Console.WriteLine(midelLine + title);
            Console.WriteLine("╚" + upperline + "╝");
            Console.ResetColor();


        }
        //recorrido de listas en busquedas
        //profesores
        public static void ListarProfesores(List<Profesor> profesores, string texto){
            Title(texto,ConsoleColor.DarkGreen);

            foreach (var profesor in profesores)
            {
                profesor.MostrarDetalles();
            }
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            Menuprofesores();
        }
        public static void ListarEstudiantes(List<Estudiante> estudiantes,string texto){
            Title(texto,ConsoleColor.DarkGreen);

            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarDetalles();
            }
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            MenuEstudiantes();
        }
        
        //estas al ser funciones de menu de usuario, las pondre aqui en lugar de ponerlas dentro de la clase administradorapp
        public static  void NuevoEstudiante(){
            Title("Nuevo Estudiante",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del estudiante: ");
            string Nombre= exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string NombreAcudiente= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Curso Actual: ");
            string CursoActual= exceptions.AntiEMptyorNull().ToUpper();
            //fecha
            int dia= exceptions.safeInt("Dia de Nacimiento: ");
            int month= exceptions.safeInt("Mes de Nacimiento: " );
            int year= exceptions.safeInt("Año de Nacimiento: ");
            
            AdministradorApp.Estudiantes.Add(new Estudiante(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono,NombreAcudiente,CursoActual,dia,month,year));
            TextoVerde("Nuevo Estudiante registrado satisfactoriamente");

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            MenuEstudiantes();
        } 
        //creacion nuevo profesor
        public static  void NuevoProfesor(){
            Title("Nuevo Profesor",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del Profesor: ");
            string Nombre= exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string Asignatura= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= exceptions.AntiEMptyorNull();
            //Salario
            double Salario= exceptions.safeDouble("Salario");
            //fecha de contratacion
            int dia= exceptions.safeInt("Dia decontratacion: ");
            int month= exceptions.safeInt("Mes de contratacion " );
            int year= exceptions.safeInt("Año decontratacion: ");

            AdministradorApp.Profesores.Add(new Profesor(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono,Asignatura,Salario,dia,month,year));
            
            TextoVerde("Nuevo Profesor registrado satisfactoriamente");

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            MenuEstudiantes();
        } 


        


    //class ends    
    }