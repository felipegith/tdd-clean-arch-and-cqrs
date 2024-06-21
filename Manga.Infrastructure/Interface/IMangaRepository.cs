namespace Manga.Infrastructure.Interface;

public interface IMangaRepository
{
    void CreateAsync(Domain.Entities.Manga manga, CancellationToken cancellationToken);
    Task<IEnumerable<Domain.Entities.Manga>> GetAllAsync(CancellationToken cancellationToken);
}