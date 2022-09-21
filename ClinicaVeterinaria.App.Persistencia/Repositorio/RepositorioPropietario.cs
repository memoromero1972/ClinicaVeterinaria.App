using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;
using System.Linq;

namespace ClinicaVeterinaria.App.Persistencia
{
   public class RepositorioPropietario:IRepositorioPropietario
   {
      private readonly AppContext _appContext;
      public RepositorioPropietario(AppContext appContext)
      {
        _appContext=appContext;
      }

      Propietario_Caballo IRepositorioPropietario.AddPropietario_Caballo(Propietario_Caballo propietario)
      {
         var PropietarioAdicionado=_appContext.Propietarios_Caballo.Add(propietario);
         _appContext.SaveChanges();
         return PropietarioAdicionado.Entity;
      }

      void  IRepositorioPropietario.DeletePropietario_Caballo(int Idpropietario)
      {
        var PropietarioEncontrado=_appContext.Propietarios_Caballo.FirstOrDefault(p=>p.Id==Idpropietario );
        _appContext.Propietarios_Caballo.Remove(PropietarioEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Propietario_Caballo> IRepositorioPropietario.GetAllPropietarios_Caballo()
      {
         return _appContext.Propietarios_Caballo;  
         //return _appContext.Propietarios.Include(p=>p.Animales);  
      }

      Propietario_Caballo IRepositorioPropietario.GetPropietario_Caballo(int Idpropietario)
      {
       return _appContext.Propietarios_Caballo.FirstOrDefault(p=>p.Id==Idpropietario);
      }

      Propietario_Caballo IRepositorioPropietario.UpdatePropietario_Caballo(Propietario_Caballo propietario)
      {
       var PropietarioEncontrado= _appContext.Propietarios_Caballo.FirstOrDefault(p=>p.Id==propietario.Id);  
        if(PropietarioEncontrado!=null)
        {
            PropietarioEncontrado.DocIdentidad=propietario.DocIdentidad;
            PropietarioEncontrado.Nombre=propietario.Nombre;
            PropietarioEncontrado.Apellidos=propietario.Apellidos;
            PropietarioEncontrado.Direccion=propietario.Direccion;
            PropietarioEncontrado.Telefono=propietario.Telefono;
            PropietarioEncontrado.Correo_Electronico=propietario.Correo_Electronico;
        
            _appContext.SaveChanges();
        }
        return PropietarioEncontrado;
      }
   }
}