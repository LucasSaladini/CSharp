using Mercadinho.Prateleira.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercadinho.Prateleira.Infraestructure.Data.DataMappings
{
    public class EstoqueMapping : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("ESTOQUE")
                .OwnsOne(n => n.InfoCompra)
                .Property(p => p.PrecoUnidade)
                .HasColumnName("PRECO_UNITARIO")
                .HasPrecision(16,4);

            builder.OwnsOne(n => n.InfoCompra)
                .Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE");

            builder.OwnsOne(n => n.InfoCompra)
                .Property(p => p.Quantidade)
                .HasColumnName("UNIDADE_MEDIDA");

            builder.HasOne(n => n.Produto)
                .WithOne(n => n.Estoque)
                .HasForeignKey<Estoque>(k => k.ProdutoId);
        }
    }
}