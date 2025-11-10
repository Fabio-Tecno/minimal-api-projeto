using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_minimal_api.Dominio.DTOs;
using projeto_minimal_api.Dominio.Entidades;

namespace projeto_minimal_api.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
      Administrador? Login(LoginDTO loginDTO);
    }
}