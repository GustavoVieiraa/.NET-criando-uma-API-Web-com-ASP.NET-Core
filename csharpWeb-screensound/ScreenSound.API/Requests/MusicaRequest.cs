using ScreenSound.Shared.Models.Models;
using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record MusicaRequest([Required]string Nome, [Required] int ArtistaId, [Required] int AnoLancamento, ICollection<GeneroRequest> Generos=null);