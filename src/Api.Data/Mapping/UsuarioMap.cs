using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(k => k.Id);

            builder.HasIndex(k => k.Email)
                    .IsUnique();
                    
            builder.Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(60);
            builder.Property(u => u.Email)
                    .HasMaxLength(100);
            builder.Property(u => u.Sobrenome)
                    .HasMaxLength(100);
        }
    }
}