using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Models
{
    public class UserModel : BaseModel
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
