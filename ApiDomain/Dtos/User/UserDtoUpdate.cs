using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage ="Id é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome é compo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é compo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
