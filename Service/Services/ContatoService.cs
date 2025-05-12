using AutoMapper;
using Domain.Entity;
using Domain.Interfaces.Infra.Repositories;
using Service.Dtos;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services;

class ContatoService : IContatoService
{
    private readonly IMapper _mapper;
    private readonly IContatoRepository _contatoRepository;

    public ContatoService(IMapper mapper, IContatoRepository contatoRepository)
    {
        _mapper = mapper;
        _contatoRepository = contatoRepository;
    }


    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Edit(Contatos model)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Contatos>> GetAll()
    {
        return await _contatoRepository.GetAll();

        //return contatos.All(p => new ContatosDTo
        //{
        //    Name = p.Name,
        //    Email = p.Email,
        //    Celular = p.Telefone,
        //    Instagram = p.Instagram
        //});
    }

    public async Task<bool> Insert(ContatosDTo model)
    {
        return await _contatoRepository.Insert(_mapper.Map<Contatos>(model));
    }
}
