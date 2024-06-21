using Manga.Infrastructure.Interface;
using MediatR;

namespace Manga.Application.Query;

public class ShowAllMangaQueryHandle : IRequestHandler<ShowAllMangaQuery, IEnumerable<Domain.Entities.Manga>>
{
    private readonly IMangaRepository _mangaRepository;

    public ShowAllMangaQueryHandle(IMangaRepository mangaRepository)
    {
        _mangaRepository = mangaRepository;
    }

    public async Task<IEnumerable<Domain.Entities.Manga>> Handle(ShowAllMangaQuery request, CancellationToken cancellationToken)
    {
        var mangas = await _mangaRepository.GetAllAsync(cancellationToken);

        if (!mangas.Any())
            return Array.Empty<Domain.Entities.Manga>();
        
        return mangas;
    }
}