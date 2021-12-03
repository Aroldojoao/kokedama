using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Kokedamas_e_TuperWares.Models;

namespace Kokedamas_e_TuperWares.Models
{
    public class Kokedama
    {

        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        //public string tipo { get; set; }
        public string tamanho { get; set; }

    }
}
