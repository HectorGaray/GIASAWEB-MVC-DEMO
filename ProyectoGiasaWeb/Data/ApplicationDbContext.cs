using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoGiasaWeb.Areas.Usuarios.Models;
using ProyectoGiasaWeb.Models;

namespace ProyectoGiasaWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext // Herencia Asp 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// Tablas Migradas
        /// </summary>
        public DbSet<TUsuarios> TUsuarios { get; set; }// --> apunta a SQL
        public DbSet<Prospectos> Prospectos { get; set; }
        public DbSet<Indirecto> Indirectos { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.Maquilas> Maquilas { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.Mano_obra> Mano_obra { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.Cat_tinta> Cat_tinta { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.CatInsumo> CatInsumo { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.Producto> Producto { get; set; }
        public DbSet<ProyectoGiasaWeb.Models.Papel> Papel { get; set; }

       
       
    }
}
