using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
