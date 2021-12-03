using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kokedamas_e_TuperWares.Models
{
    public class Modelo
    {

        [Key]
        public int id { get; set; }
        public string Modelos { get; set; }
    }

}