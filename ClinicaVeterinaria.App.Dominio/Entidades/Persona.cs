using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public string? DocIdentidad {get;set;}
        public string? Nombre {get; set;}
        public string? Apellidos {get; set;}
        public string? Direccion {get; set;}
        public string? Telefono {get; set;}         
    }


}