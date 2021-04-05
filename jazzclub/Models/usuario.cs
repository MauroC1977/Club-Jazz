﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jazzclub.Models
{
    public class usuario
    {
        public int ID { get; set; }
        public string nombre { get; set; }

        public string celular { get; set; }


        [EmailAddress(ErrorMessage = "Debe ingresar un email valido")]
        public string email { get; set; }

        public string ciudad { get; set; }

        public string fecharegistro { get; set; }
    }
}