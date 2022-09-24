using System.Collections.Generic;  //libreria donde se definen las interfaces
using ClinicaVeterinaria.App.Dominio;
using System.Linq;


namespace ClinicaVeterinaria.App.Persistencia
{
   public class RepositorioCaballo:IRepositorioCaballo
   {
      private readonly AppContext _appContext;
      public RepositorioCaballo(AppContext appContext)
      {
        _appContext=appContext;
      }

      Caballo IRepositorioCaballo.AddCaballo(Caballo caballo)
      {  
         var CaballoAdicionado=_appContext.Caballos.Add(caballo);
         _appContext.SaveChanges();
         return CaballoAdicionado.Entity;
      }

      void  IRepositorioCaballo.DeleteCaballo(int Idcaballo)
      {
        var CaballoEncontrado=_appContext.Caballos.FirstOrDefault(p=>p.Id==Idcaballo);
       
        _appContext.Caballos.Remove(CaballoEncontrado);
        _appContext.SaveChanges();
      }

      IEnumerable<Caballo> IRepositorioCaballo.GetAllCaballos()
      {
         return _appContext.Caballos;  
         //return _appContext.Propietarios.Include(p=>p.Animales);  
      }

      Caballo IRepositorioCaballo.GetCaballo(int Idcaballo)
      {
       return _appContext.Caballos.FirstOrDefault(p=>p.Id==Idcaballo);
      }

      Caballo IRepositorioCaballo.UpdateCaballo(Caballo caballo)
      {
       var CaballoEncontrado= _appContext.Caballos.FirstOrDefault(p=>p.Id==caballo.Id);  
        if(CaballoEncontrado!=null)
        {
         CaballoEncontrado.Nombre_Caballo=caballo.Nombre_Caballo;
         CaballoEncontrado.Color=caballo.Color;
         CaballoEncontrado.Especie=caballo.Especie;
         CaballoEncontrado.Raza=caballo.Raza;
          _appContext.SaveChanges();
        }
        return CaballoEncontrado;
      }
   }
}