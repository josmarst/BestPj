using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBPJ.Models
{
    public class Contato
    {
        [Key]
        public int idContato { get; set; }


        [Required(ErrorMessage = "O Nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public string Celular { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone Res.")]
        public string TelResidencial { get; set; }
    }
}