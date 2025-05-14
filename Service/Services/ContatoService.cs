using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Infra.Repositories;
using Service.Dtos;
using Service.Interfaces;


namespace Service.Services;

public class ContatoService : IContatoService
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

    public async Task<IEnumerable<ContatosDTo>> GetAll()
    {
        var contatos = await _contatoRepository.GetAll();

        return contatos.Select(p => new ContatosDTo
        {
            Name = p.Name,
            Email = p.Email,
            Celular = p.Telefone,
            Instagram = p.Instagram
        });
    }

    public async Task<bool> Insert(ContatosDTo model)
    {
        return await _contatoRepository.Insert(_mapper.Map<Contatos>(model));
    }
}
