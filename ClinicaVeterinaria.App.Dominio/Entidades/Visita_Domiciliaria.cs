using System;

namespace ClinicaVeterinaria.App.Dominio
{
    public class Visita_Domiciliaria
    {
        public int Id_Historia {get; set;}
        public int Id {get; set;}
        public int Id_Profesional {get; set;}
        public int Temperatura {get; set;}
        public int Peso {get; set;}
        public int Frecuencia_Respiratoria {get; set;}
        public int Frecuencia_Cardiaca {get; set;}
        public int Estado_Animo {get; set;}
        public int Fecha_Visita {get; set;}
        
    }


}