using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos
{
   public class LoginDto
    {
        [Required(ErrorMessage ="Email é compo obrigatório para Login")]
        [EmailAddress(ErrorMessage ="E-mail em formato inválido")]
        [StringLength(100,ErrorMessage ="Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
