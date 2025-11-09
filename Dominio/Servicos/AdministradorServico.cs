using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_minimal_api.Dominio.DTOs;
using projeto_minimal_api.Dominio.Entidades;
using projeto_minimal_api.Dominio.Interfaces;
using projeto_minimal_api.Infraestrutura;

namespace projeto_minimal_api.Dominio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;

        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(
            a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).
            FirstOrDefault();
            return adm;
        }
    }
}