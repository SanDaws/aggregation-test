using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public class Profesor:Persona{
    public string Asignatura{get;set;}
    private double Salario{get;set;}
    public DateTime FechaContratacion{get;set;}
    public List<string>Cursos;

    public Profesor(string Nombre,string Apellido,string TipoDocumento,string NumeroDocumento,string Email,string Telefono,string Asignatura,double Salario,int dia,int mes, int year):base(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono){
        this.Asignatura=Asignatura;
        this.Salario=Salario;
        FechaContratacion= new DateTime(year,mes,dia);
        Cursos = new List<string>();


    }

    public int CalcularAntiguedad(){
        int antiguedad= FechaContratacion.CompareTo(DateTime.Now);
        return antiguedad;
    }
    public void ObtenerSalario(){
        Console.WriteLine("Salario del profesor: {0}",Salario);
        
    }
        public static  void agregarCurso(string curso,string documento ){

        // Encuentra el profesor con el número de documento específico
        Profesor? prof = AdministradorApp.Profesores.FirstOrDefault(p => p.NumeroDocumento == documento);
        if (prof != null)
        {
        prof.Cursos.Add(curso);
        }
        Uti.TextoVerde("agregadoSarisfactoriamente");

    }
    public override void MostrarDetalles()
    {
        Console.WriteLine($"{Nombre,20} {Apellido,30} {Asignatura,40} {TipoDocumento,15} {NumeroDocumento} {Email,50} {Telefono,20} {Salario,20:c} {string.Join(", ",Cursos)} ");

}
}
