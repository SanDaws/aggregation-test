using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;


public class Estudiante : Persona
{
    //Atributos

    public string NombreAcudiente { get; set; }
    public string CursoActual { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public List<double> Calificaciones { get; set; }
    public Estudiante(string Nombre,string Apellido,string TipoDocumento,string NumeroDocumento,string Email,string Telefono, string NombreAcudiente,string CursoActual,int day,int month, int year):base(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono){
        this.NombreAcudiente=NombreAcudiente;
        this.CursoActual=CursoActual;
        FechaNacimiento= new DateOnly(year,month,day);
        Calificaciones= new List<double>();
    }

    //metodos

    //agrega calificaiones dentro del propio historial del estudiante
    public void AgregarCalificacion(double calificacion)
    {
        Calificaciones.Add(calificacion);
    }
    //muestra promedio de el estudiante
    public void CalcularPromedio(){
        double result = Calificaciones.Average();

        Console.WriteLine("Resultado: ");

        // calificaiones de 1 a 100= 75 minimo
        if (result<75)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Cambia el color del texto a rojo
            Console.Write(result);
        }else
        {
           Console.ForegroundColor = ConsoleColor.Green; // Cambia el color del texto a rojo
            Console.Write(result);
        }
    }
    //calcula edad de estudiante
    public int CalcularEdad(){
        DateOnly datenow=DateOnly.FromDateTime(DateTime.Now);
        
        int edad =datenow.Year - FechaNacimiento.Year;
        return edad;
    }

    //formato sobreescrito de 
    public override void MostrarDetalles(){
        Console.WriteLine($"{Nombre +" "+ Apellido,30} {CursoActual,8} {NombreAcudiente,30} {TipoDocumento,15} {NumeroDocumento,-15} {Email,50} {Telefono,20} {CalcularEdad(),12} ");
    }


    public static Estudiante EstudianteporDocumento(string Documento)
    {
        Estudiante? estudiante = AdministradorApp.Estudiantes.FirstOrDefault(p => p.NumeroDocumento == Documento);
        if (estudiante != null)
        {
            return estudiante;
        }
        Uti.TextoRojo("Estudiante no existe");
        return null;

    }
}
