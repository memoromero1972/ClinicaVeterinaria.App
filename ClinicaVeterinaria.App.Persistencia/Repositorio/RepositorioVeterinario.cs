using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
   public class RepositorioVeterinario:IRepositorioVeterinario
   {
      private readonly AppContext _appContext;
      public RepositorioVeterinario(AppContext appContext)
      {
        _appContext=appContext;
      }

      Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
      {
         var VeterinarioAdicionado=_appContext.Veterinarios.Add(veterinario);
         _appContext.SaveChanges();
         return VeterinarioAdicionado.Entity;
      }

      void  IRepositorioVeterinario.DeleteVeterinario(int Idveterinario)
      {
        var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p=>p.Id==Idveterinario);
        _appContext.Veterinarios.Remove(VeterinarioEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
      {
         return _appContext.Veterinarios;  
         //return _appContext.Propietarios.Include(p=>p.Animales);  
      }

      Veterinario IRepositorioVeterinario.GetVeterinario(int Idveterinario)
      {
       return _appContext.Veterinarios.FirstOrDefault(p=>p.Id==Idveterinario);
      }

      Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
      {
       var VeterinarioEncontrado= _appContext.Veterinarios.FirstOrDefault(p=>p.Id==veterinario.Id);  
        if(VeterinarioEncontrado!=null)
        {
            VeterinarioEncontrado.DocIdentidad=veterinario.DocIdentidad;
            VeterinarioEncontrado.Nombre=veterinario.Nombre;
            VeterinarioEncontrado.Apellidos=veterinario.Apellidos;
            VeterinarioEncontrado.Direccion=veterinario.Direccion;
            VeterinarioEncontrado.Telefono=veterinario.Telefono;
            VeterinarioEncontrado.Num_Tarjeta_Profesional=veterinario.Num_Tarjeta_Profesional;
        
            _appContext.SaveChanges();
        }
        return VeterinarioEncontrado;
      }
   }
}