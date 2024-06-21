using Manga.Infrastructure.Context;
using Manga.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Manga.Infrastructure.Repositories;

public class MangaRepository : IMangaRepository
{
    private readonly Database _database;

    public MangaRepository(Database database)
    {
        _database = database;
    }

    public void CreateAsync(Domain.Entities.Manga manga, CancellationToken cancellationToken)
    {
        try
        {
            _database.Mangas.Add(manga);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<IEnumerable<Domain.Entities.Manga>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _database.Mangas.AsNoTracking().ToListAsync(cancellationToken);
    }
}