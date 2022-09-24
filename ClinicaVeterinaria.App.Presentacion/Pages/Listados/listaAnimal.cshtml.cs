using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

//librerias opcionales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.App.Presentacion.Pages
{
    public class listaAnimalModel : PageModel
    {
        private readonly IRepositorioCaballo repCaballo;
        public IEnumerable<Caballo> caballolista {set;get;}
        public listaAnimalModel()
        {
            this.repCaballo= new RepositorioCaballo(new ClinicaVeterinaria.App.Persistencia.AppContext());
        }   
        public void OnGet(string filtroBusqueda)
        {
            caballolista=repCaballo.GetAllCaballos();
        }
    }
}