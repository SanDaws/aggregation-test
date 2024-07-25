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


    }

    public int CalcularAntiguedad(){
        int antiguedad= FechaContratacion.CompareTo(DateTime.Now);
        return antiguedad;
    }
    public void ObtenerSalario(){
        Console.WriteLine("Salario del profesor: {0}",Salario);
    }
    public override void MostrarDetalles()
    {
        
    }

}
