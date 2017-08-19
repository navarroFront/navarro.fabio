﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDPosUnivem.Domain.Entities;
using DDDPosUnivem.Domain.Interfaces.Repositories;

namespace DDDPosUnivem.Infra.Data.Repositories
{
    public class ProdutoRepository: RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
