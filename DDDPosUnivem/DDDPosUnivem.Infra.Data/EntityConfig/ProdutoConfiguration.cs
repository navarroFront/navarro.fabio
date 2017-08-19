﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDPosUnivem.Domain.Entities;

namespace DDDPosUnivem.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome).IsRequired().HasMaxLength(250);
            Property(p => p.Valor).IsRequired();

            //Foreign Key

            HasRequired(p => p.Cliente)
                .WithMany() //Um Cliente tem muitos Produtos
                .HasForeignKey(p => p.ClienteId); //Chave do relacionamento
        }
    }
}
