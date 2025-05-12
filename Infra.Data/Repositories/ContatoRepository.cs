using Domain.Entity;
using Domain.Interfaces.Infra.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories;

public class ContatoRepository : IContatoRepository
{
    private readonly ContatoContext _dbContext;
    public ContatoRepository(ContatoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Edit(Contatos entidades)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Contatos>> GetAll()
    {
        return await _dbContext.Contatos.ToListAsync();
    }

    public async Task<bool> Insert(Contatos entidades)
    {
        await _dbContext.Set<Contatos>().AddAsync(entidades);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}
