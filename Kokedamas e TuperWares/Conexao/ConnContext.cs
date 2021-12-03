using System.Data.Entity;
using Kokedamas_e_TuperWares.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokedamas_e_TuperWares.Conexao
{
    public class ConnContext : DbContext
    {
        public DbSet<Kokedama> kokedamasdb { get; set; }
        public DbSet<Tipo> tipodb { get; set; }
        public DbSet<Modelo> Modelodb { get; set; }


    }
}