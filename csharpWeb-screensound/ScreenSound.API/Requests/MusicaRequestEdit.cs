using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record MusicaRequestEdit([Required] int Id, [Required] string Nome, [Required] int AnoLancamento);
