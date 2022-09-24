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
    public class RegistroPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario repPropietario;
        public RegistroPropietarioModel()
        {
            this.repPropietario = new RepositorioPropietario (new ClinicaVeterinaria.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Propietario_Caballo propietario {set;get;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          repPropietario.AddPropietario_Caballo(propietario);  
          return RedirectToPage();
        }
    }
}
