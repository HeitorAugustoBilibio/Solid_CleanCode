﻿using Domain.Entities;
using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces;

public interface IContatoService
{
    Task<bool> Insert(ContatosDTo model);

    Task<IEnumerable<ContatosDTo>> GetAll();

    Task<bool> Edit(Contatos model);

    Task<bool> Delete(int id);
}
