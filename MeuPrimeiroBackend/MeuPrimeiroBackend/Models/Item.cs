using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeuPrimeiroBackend.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int DanoMaximo { get; set; }

        public int DanoMinimo { get; set; }

        public int Durabilidade { get; set; }

        public bool Ativo { get; set; }
    }
}