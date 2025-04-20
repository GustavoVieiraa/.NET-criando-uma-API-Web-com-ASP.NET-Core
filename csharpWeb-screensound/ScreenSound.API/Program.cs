using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScreenSound.API.Endpoints;
using ScreenSound.Data;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();
builder.Services.AddTransient<DAL<Musica>>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/", () => " API do Projeto ScreenSound está rodando!");

app.AddEndpointsArtistas();

app.AddEndpointsMusicas();

app.Run();
