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
        Console.ForegroundColor = ConsoleColor.Red; // Cambia el color del texto a rojo
        Console.Write(result);
    }
    //calcula edad de estudiante
    public int CalcularEdad(){
        int edad = FechaNacimiento.CompareTo(DateOnly.FromDateTime(DateTime.Now));
        return edad;
    }

    //formato sobreescrito de 
    public override void MostrarDetalles(){
        Console.WriteLine($"{Nombre,20} {Apellido,30} {CursoActual,8} {NombreAcudiente,50} {TipoDocumento,15} {NumeroDocumento} {Email,50} {Telefono,20} {CalcularEdad()} ");
    }
}
