using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;

namespace ClinicaVeterinaria.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int Idveterinario);
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario GetVeterinario(int Idveterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
    }
}