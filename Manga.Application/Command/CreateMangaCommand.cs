using MediatR;

namespace Manga.Application.Command;

public record CreateMangaCommand(string Name, float Rating, bool Read) : IRequest<Guid>; 
