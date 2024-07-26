using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public static void TextoVerde(string texto){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(texto);
        Console.ResetColor();

    }
    public static void TextoRojo(string texto){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(texto);
        Console.ResetColor();

    }

    public static void IntControlParsing(){
        try
        {
           int result=int.Parse(Console.ReadLine()); 
        }
        catch ()
        {
            
            throw;
        }
    }




}
