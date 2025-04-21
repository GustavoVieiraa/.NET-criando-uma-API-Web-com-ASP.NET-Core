using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Data;
using ScreenSound.Modelos;

namespace ScreenSound.API.Endpoints
{
    public static class ArtistasExtensions
    {
        public static void AddEndpointsArtistas(this WebApplication app) {
            #region Endpoint Artistas
            app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
            {

                var listaDeArtistas = dal.Listar();

                if (listaDeArtistas is null)
                {
                    return Results.NotFound();
                }

                var listaDeArtistaResponse = EntityListToResponseList(listaDeArtistas);

                return Results.Ok(listaDeArtistaResponse);

                
            });

            app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
            {
                var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));

                if (artista is null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(EntityToResponse(artista));

            });

            app.MapPost("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequest artistaRequest) => {
                var artista = new Artista(artistaRequest.Nome, artistaRequest.Bio);
                dal.Adicionar(artista);
                return Results.Ok();
            });

            app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> dal, int id) =>
            {
                var artista = dal.RecuperarPor(a => a.Id == id);
                if (artista is null)
                {
                    return Results.NotFound();
                }

                dal.Deletar(artista);

                return Results.NoContent();

            });

            app.MapPut("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequestEdit artistaRequestEdit) =>
            {
                var artistaParaAtualizar = dal.RecuperarPor(a => a.Id == artistaRequestEdit.Id);

                if (artistaParaAtualizar is null)
                {
                    return Results.NotFound();
                }

                artistaParaAtualizar.Nome = artistaRequestEdit.Nome;
                artistaParaAtualizar.Bio = artistaRequestEdit.Bio;
                artistaParaAtualizar.FotoPerfil = artistaRequestEdit.FotoPerfil;

                dal.Atualizar(artistaParaAtualizar);

                return Results.Ok();

            });
        #endregion
        }
        private static ICollection<ArtistaResponse> EntityListToResponseList(IEnumerable<Artista> listaDeArtistas)
        {
            return listaDeArtistas.Select(a => EntityToResponse(a)).ToList();
        }

        private static ArtistaResponse EntityToResponse(Artista artista)
        {
            return new ArtistaResponse(artista.Id, artista.Nome, artista.Bio, artista.FotoPerfil);
        }
    }
}
