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
    public class EditarAnimalModel : PageModel
    {
        private readonly IRepositorioCaballo repCaballo;
        [BindProperty]
        public Caballo caballo {set;get;}
        public EditarAnimalModel()
        {
            this.repCaballo=new RepositorioCaballo(new ClinicaVeterinaria.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idcaballo)
        {
            caballo=repCaballo.GetCaballo(idcaballo);
          if(caballo==null){
            return RedirectToPage("/Menuopciones/NoFound");
           }
           else{
            return Page();
           }

        }
        public IActionResult OnPost()
        {
             caballo=repCaballo.UpdateCaballo(caballo);
           //repositorioPropietario.DeletePropietario(propietario.IdPersona);
            return RedirectToPage("/Listados/listaAnimal");
        }
    }
}
