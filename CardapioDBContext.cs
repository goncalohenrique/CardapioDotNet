namespace Goncalo.Cardapio.Api;

using Microsoft.EntityFrameworkCore;

public class CardapioDBContext : DbContext
{
    public CardapioDBContext(DbContextOptions<CardapioDBContext> options) : base(options)
    { }
    
    public DbSet<ItemCardapio> Itens => Set<ItemCardapio>();
}
