using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public class Profesor:Persona{
    public string Asignatura{get;set;}
    private double Salario{get;set;}
    public DateOnly FechaContratacion{get;set;}
    public List<string>Cursos;

    public int CalcularSalario(){
        return 0;
    }
    public void ObtenerSalario(){}
    public override void MostrarDetalles()
    {
        
    }

}
