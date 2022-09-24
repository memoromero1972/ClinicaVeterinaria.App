using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;

//librerias opcionales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.App.Presentacion.Pages
{
    public class RegistroAnimalModel : PageModel
    {
        private readonly IRepositorioCaballo repCaballo;
        public RegistroAnimalModel()
        {
            this.repCaballo = new RepositorioCaballo (new ClinicaVeterinaria.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Caballo caballo {set;get;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          repCaballo.AddCaballo(caballo);  
          return RedirectToPage("/Listados/ListaAnimal");
        }
    }
}
