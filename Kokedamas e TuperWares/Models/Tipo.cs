using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokedamas_e_TuperWares.Models
{
    public class Tipo
    {

            [Key]
            public int id { get; set; }
            public string Descricao { get; set; }
    }
    
}