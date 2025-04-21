using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record ArtistaRequestEdit([Required] int Id, string Nome, [Required] string Bio, [Required] string FotoPerfil);