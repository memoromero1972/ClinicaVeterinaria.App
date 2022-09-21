using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        Propietario_Caballo AddPropietario_Caballo(Propietario_Caballo propietario);
        void DeletePropietario_Caballo(int Idpropietario);
        IEnumerable<Propietario_Caballo> GetAllPropietarios_Caballo();
        Propietario_Caballo GetPropietario_Caballo(int Idpropietario);
        Propietario_Caballo UpdatePropietario_Caballo(Propietario_Caballo propietario);
    }

}