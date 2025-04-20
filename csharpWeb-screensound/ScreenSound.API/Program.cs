using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Data;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/", () => " API do Projeto ScreenSound está rodando!");

app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Artistas/{nome}", (string nome) =>
{
    var context = new ScreenSoundContext();
    var artista = context.Artistas
            .Include(a => a.Musicas) 
            .FirstOrDefault(a => a.Nome.ToUpper().Equals(nome.ToUpper()));

    if (artista is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(artista);

});

app.MapPost("/Artistas", ([FromServices] DAL < Artista > dal, [FromBody]Artista artista) => {
    dal.Adicionar(artista);
    return Results.Ok();
});

app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> dal, int id) =>
{
    var artista = dal.RecuperarPor(a => a.Id == id);
    if (artista is null) {
        return Results.NotFound();
    }

    dal.Deletar(artista);

    return Results.NoContent();

});

app.MapPut("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody]Artista artista) =>
{
    var artistaParaAtualizar = dal.RecuperarPor(a => a.Id == artista.Id);

    if (artistaParaAtualizar is null) {
        return Results.NotFound();
    }

    artistaParaAtualizar.Nome = artista.Nome;
    artistaParaAtualizar.Bio = artista.Bio;
    artistaParaAtualizar.FotoPerfil = artista.FotoPerfil;

    dal.Atualizar(artistaParaAtualizar);

    return Results.Ok();

});

app.Run();
