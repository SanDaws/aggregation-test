using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public class Persona{
    protected Guid Id{get;set;}
    protected string Nombre{get;set;}
    protected string Apellido{get;set;}
    protected string TipoDocumento{get;set;}
    protected string NumeroDocumento{get;set;}   
    protected string Email{get;set;}
    protected string Telefono{get;set;}

    public Persona(string Nombre,string Apellido,string TipoDocumento,string NumeroDocumento,string Email,string Telefono){
        Id=Guid.NewGuid();
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.TipoDocumento=TipoDocumento;
        this.NumeroDocumento=NumeroDocumento;
        this.Email=Email;
        this.Telefono=Telefono;

    }
    public virtual void MostrarDetalles(){}




}
