using Domain.Entities;


namespace Domain.Interfaces.Infra.Repositories
{
    public interface IContatoRepository
    {
        Task<bool> Insert(Contatos entidades);

        Task<IEnumerable<Contatos>> GetAll();

        Task<bool> Edit(Contatos entidades);

        Task<bool> Delete(int id);
    }
}
