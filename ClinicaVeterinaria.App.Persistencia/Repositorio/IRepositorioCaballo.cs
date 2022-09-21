using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioCaballo
    {
        Caballo AddCaballo(Caballo caballo);
        void DeleteCaballo(int Idcaballo);
        IEnumerable<Caballo> GetAllCaballos();
        Caballo GetCaballo(int Idcaballo);
        Caballo UpdateCaballo(Caballo caballo);
    } 
}