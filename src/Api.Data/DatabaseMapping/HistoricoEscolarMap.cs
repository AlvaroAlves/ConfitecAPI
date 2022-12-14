using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.DatabaseMapping
{
    public class HistoricoEscolarMap : IEntityTypeConfiguration<HistoricoEscolarEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoEscolarEntity> builder)
        {
            builder.ToTable("HistoricosEscolares");

            builder.HasKey(k => k.Id);
            builder.Property(h => h.Id)
                    .ValueGeneratedOnAdd();        
            builder.Property(h => h.Nome)
                    .IsRequired()
                    .HasMaxLength(60);
            builder.Property(h => h.Formato)
                    .HasMaxLength(5);
            
        }
    }
}