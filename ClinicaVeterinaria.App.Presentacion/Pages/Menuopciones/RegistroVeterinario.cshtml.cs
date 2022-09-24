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
    public class RegistroVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repVeterinario;
        public RegistroVeterinarioModel()
        {
            this.repVeterinario = new RepositorioVeterinario (new ClinicaVeterinaria.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Veterinario veterinario {set;get;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          repVeterinario.AddVeterinario(veterinario);  
          return RedirectToPage();
        }
    }
}
