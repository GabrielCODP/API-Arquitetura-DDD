﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiIntegrationTest
{
    public class TesteLogin : BaseIntegration
    {
         [Fact]
        public async Task TesteDoToken()
        {
           await AdicionarToken();
        }
    }
}
