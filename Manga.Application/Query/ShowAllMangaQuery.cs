using MediatR;

namespace Manga.Application.Query;

public record ShowAllMangaQuery : IRequest<IEnumerable<Domain.Entities.Manga>>;
