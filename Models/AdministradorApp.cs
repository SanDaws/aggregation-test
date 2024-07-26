using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public static class AdministradorApp{
    public static List<Estudiante> Estudiantes= new List<Estudiante>();
    public static List<Profesor> Profesores= new List<Profesor>();

    public static void AgregarEstudiante(Estudiante estudiante){
        Estudiantes.Add(estudiante);
    }

    public static void AgregarProfesor(Profesor profesor){
        Profesores.Add(profesor);
    }
    public static void MostrarEstudiantes(){
        foreach (Estudiante estudiante in Estudiantes)
        {
            estudiante.MostrarDetalles();
        }

    }
    //show all the teachers that are in the list
    public static void MostrarProfesores(){
        foreach (Profesor profesor in Profesores)
        {
            profesor.MostrarDetalles();
        }
    }


    public static void RemoverEstudiante(){
        Uti.Title("eliminar Estudiante",ConsoleColor.Red);
        Console.Write("Documento del estudiante: ");
        string documento = exceptions.AntiEMptyorNull();
         
        if (Estudiante.EstudianteporDocumento(documento) == null)
        {
            Uti.TextoRojo("Estudiante No encontrado");
            Console.WriteLine(" oprima cualquier boton para volver a empezar...");
            Console.ReadKey();

            RemoverEstudiante();
        }else{
            Estudiante _estudiante=Estudiante.EstudianteporDocumento(documento);
            _estudiante.MostrarDetalles();
            Estudiantes.Remove(Estudiante.EstudianteporDocumento(documento));

            Uti.TextoVerde("Registro Eliminado Satisfactoriamente");
            

        }

        Console.WriteLine(" oprima cualquier boton para volver al...");
        Console.ReadKey();
        Uti.MenuEstudiantes();


    }
    
    public static void RemoverProfesor(){
        Uti.Title("eliminar Profesor",ConsoleColor.Red);
        Console.Write("Documento del estudiante: ");
        string documento = exceptions.AntiEMptyorNull();
         
        if (Profesor.ProfesorporDocumento(documento) == null)
        {
            Uti.TextoRojo("Profesor No encontrado");
            Console.WriteLine(" oprima cualquier boton para volver a empezar...");
            Console.ReadKey();

            RemoverProfesor();
        }else{
            Profesor _profesore=Profesor.ProfesorporDocumento(documento);
            _profesore.MostrarDetalles();
            Profesores.Remove(_profesore);

            Uti.TextoVerde("Registro Eliminado Satisfactoriamente");
            

        }

        Console.WriteLine(" oprima cualquier boton para volver al...");
        Console.ReadKey();
        Uti.MenuEstudiantes();


    }

    public static void PromedioNotas(){
         Uti.Title("Promedio de estudiante",ConsoleColor.Yellow);
        Console.Write("Documento del estudiante: ");
        string documento = exceptions.AntiEMptyorNull();
         
        if (Estudiante.EstudianteporDocumento(documento) == null)
        {
            Uti.TextoRojo("Estudiante No encontrado");
            Console.WriteLine(" oprima cualquier boton para volver a empezar...");
            Console.ReadKey();

            PromedioNotas();
        }else{
            Estudiante _estudiante=Estudiante.EstudianteporDocumento(documento);
            _estudiante.MostrarDetalles();
           _estudiante.CalcularPromedio();
            

        }
    }

     public static void SalarioProfesor(){
        Uti.Title("SalarioProfesor",ConsoleColor.Yellow);
        Console.Write("Documento del Profesor: ");
        string documento = exceptions.AntiEMptyorNull();
         
        if (Profesor.ProfesorporDocumento(documento) == null)
        {
            Uti.TextoRojo("Profesor No encontrado");
            Console.WriteLine(" oprima cualquier boton para volver a empezar...");
            Console.ReadKey();

            RemoverProfesor();
        }else{
            Profesor _profesore=Profesor.ProfesorporDocumento(documento);
            _profesore.ObtenerSalario();
            

        }

        Console.WriteLine(" oprima cualquier boton para volver al...");
        Console.ReadKey();
        Uti.MenuEstudiantes();


    }



}
