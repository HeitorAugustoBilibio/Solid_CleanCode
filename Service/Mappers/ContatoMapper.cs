using AutoMapper;
using Domain.Entities;
using Service.Dtos;


namespace Service.Mappers;

class ContatoMapper : Profile
{
    public ContatoMapper()
    {
        CreateMap<ContatosDTo, Contatos>();
    }
}
