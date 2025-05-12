using AutoMapper;
using Domain.Entity;
using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappers;

class ContatoMapper : Profile
{
    public ContatoMapper()
    {
        CreateMap<ContatosDTo, Contatos>();
    }
}
