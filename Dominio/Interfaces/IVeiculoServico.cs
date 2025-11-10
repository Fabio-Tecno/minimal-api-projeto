using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_minimal_api.Dominio.DTOs;
using projeto_minimal_api.Dominio.Entidades;

namespace projeto_minimal_api.Dominio.Interfaces
{
    public interface IVeiculoServico
    {
     List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null);
    Veiculo? BuscarPorId(int id);
    void Incluir(Veiculo veiculo);
    void Atualizar(Veiculo veiculo);
    void Apagar(Veiculo veiculo);

    }
}