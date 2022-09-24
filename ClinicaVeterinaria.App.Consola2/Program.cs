using System;
using ClinicaVeterinaria.App.Dominio;
using ClinicaVeterinaria.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaVeterinaria.App.Consola2
{
    class Program

    {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioCaballo _repoCaballo = new RepositorioCaballo(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ejercicio insercion de datos ");
            AddDatos();
            BuscarPropietario(18);
        }

        private static void AddDatos()
        {
            var propietario = new   Propietario_Caballo()
            {
                
                DocIdentidad="80808999",
                Nombre="Carlos Felipe",
                Apellidos="Romero Galvis",
                Direccion="Cr 68A 23B53",
                Telefono="3153310001",
                Correo_Electronico= "feliperro1@hotmail.com"
            };
            _repoPropietario.AddPropietario_Caballo(propietario);
            
            var propietario1 = new   Propietario_Caballo()
            {
                
                DocIdentidad="80801000",
                Nombre="Carlos Andres",
                Apellidos="Mora Hernandez",
                Direccion="Cll 147 19A28",
                Telefono="3153310002",
                Correo_Electronico= "CarAndMor@hotmail.com"
            };
            _repoPropietario.AddPropietario_Caballo(propietario1);

            var veterinario = new Veterinario()
            {
                
                DocIdentidad="1218715442",
                Nombre="Emmanuel",
                Apellidos="Romero Ayure",
                Direccion="Cr 68A 23b53",
                Telefono="6012696345",
                TarjetaProf="TP-010-000002"
            };
            _repoVeterinario.AddVeterinario(veterinario);

            var veterinario1 = new Veterinario()
            {
                
                DocIdentidad="1218715441",
                Nombre="Natalia Maria",
                Apellidos="Romero Bahamon",
                Direccion="Cll 22Bis 48-20",
                Telefono="6012696342",
                TarjetaProf="TP-010-000001"
            };
            _repoVeterinario.AddVeterinario(veterinario1);

            var caballo = new Caballo()
            {
            
                Nombre_Caballo="Petronilo",
                Color="Blanco y negro",
                Especie="Mula",
                Raza="Chandoso",

            };
            _repoCaballo.AddCaballo(caballo);

            var caballo1 = new Caballo()
            {
            
                Nombre_Caballo="Tiro Loco Mc Graw",
                Color="Blanco y Gris",
                Especie="Caballo",
                Raza="Piojoso",

            };
            _repoCaballo.AddCaballo(caballo1);
            var Lista=_repoCaballo.GetAllCaballos();
            foreach (var i in Lista)
            {
                Console.WriteLine(i.Nombre_Caballo);
            }
            

        }
        private static void BuscarPropietario(int idcliente)
        {
            var propietario = _repoPropietario.GetPropietario_Caballo(idcliente);
            Console.WriteLine(propietario.Nombre);

        }

    }
}
