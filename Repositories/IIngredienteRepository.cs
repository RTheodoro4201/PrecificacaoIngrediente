using Precificacao.Models;

namespace Precificacao.Repositories;

public interface IIngredienteRepository : IRepository<Ingrediente>
{
    Task UpdateQuantidade(Ingrediente entity, decimal quantidade);
}