using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public class Estudiante:Persona{
public string NombreAcudiente{get;set;}
public string CursoActual{get;set;}
public DateOnly FechaNacimiento{get;set;}

public List<double> Calificaciones{get;set;}

public void AgregarCalificacion(){}
public void CalcularPromedio(){}
public int CalcularEdad(){
    return 0;
}


public override void MostrarDetalles()
    {
        
    }
}
