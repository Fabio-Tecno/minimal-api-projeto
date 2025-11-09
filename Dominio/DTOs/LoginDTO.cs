using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_minimal_api.Dominio.DTOs
{
    public class LoginDTO
    {
         public string Email { get; set; } = default!;
         public string Senha { get; set; } = default!;
    }
}