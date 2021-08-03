using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public abstract class BaseEntity
    {
        //Essa base vai ser utilizado como herança de outra classe, por isso é abstract

        //Vai virar uma chave primaria 
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;

        public DateTime? CreateAt
        {
            get { return _createAt; }

            //tratamento, caso receber null vai receber o valor do servidor da máquina.
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

    }
}
