using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage ="Nome de Município é campo Obrigatorio!")]
        [StringLength(60,ErrorMessage ="Nome de Município deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Range(0,int.MaxValue,ErrorMessage ="Código do IBGE Inválido")]
        public int CodIBGE { get; set; }


        [Required(ErrorMessage = "Código de UF é campo Obrigatorio.")]
        public Guid UfId { get; set; }
    }
}
