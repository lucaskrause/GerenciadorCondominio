using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapeamentos
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);
            builder.HasData(
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Morador",
                    NormalizedName = "MORADOR",
                    Descricao = "Morador do Predio"
                },

                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Sindico",
                    NormalizedName = "SINDICO",
                    Descricao = "Sindico do Predio"
                },

                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "Administrador do Predio"
                }
            );
            builder.ToTable("Funcoes");
        }
    }
}
