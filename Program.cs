using Microsoft.EntityFrameworkCore;
using Goncalo.Cardapio.Api;

var builder = WebApplication.CreateBuilder(args);

// Configura o banco de dados na memória (Injeção de Dependência)
builder.Services.AddDbContext<CardapioDBContext>(options => 
    options.UseInMemoryDatabase("CardapioDB")
);

var app = builder.Build();

// Listar cardapio
app.MapGet("/cardapio", 
    async (CardapioDBContext db) =>
    await db.Itens.ToListAsync());

app.MapPost("/cardapio",
    async (ItemCardapio itemNovo, CardapioDBContext db) =>
    {
        db.Itens.Add(itemNovo);
        await db.SaveChangesAsync();
        return Results.Created($"/cardapio/{itemNovo.id}", itemNovo);
    });

app.Run();
    