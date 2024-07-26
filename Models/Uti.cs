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
        0: Salir");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    ListarEstudiantes(AdministradorApp.Estudiantes,"Todos los Estudiantes");
                    break;
                case ConsoleKey.D2:// case employe menu

                    break;
                case ConsoleKey.D3:// case customer menu

                    break;
                case ConsoleKey.D0:// case exit

                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("opcion no valida");

                    break;
            }
        }
        public static void Menuprofesores(){
            Title("Profesores",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista De Profesores
        2: Empleados
        3: Edita
        0: Salir");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    ListarProfesores(AdministradorApp.Profesores,"Todos los profesores");
                    break;
                case ConsoleKey.D2:// case employe menu

                    break;
                case ConsoleKey.D3:// case customer menu

                    break;
                case ConsoleKey.D0:// case exit

                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("opcion no valida");

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

        public static  void NuevoEstudiante(){
            
            

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            MenuEstudiantes();
        } 



    //class ends    
    }