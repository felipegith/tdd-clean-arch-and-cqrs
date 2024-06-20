using Manga.Infrastructure.Context;
using Manga.Infrastructure.Interface;

namespace Manga.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly Database _database;

    public UnitOfWork(Database context)
    {
        _database = context;
    }
    public async Task<bool> Commit()
    {
        var success = (await _database.SaveChangesAsync()) > 0;

        return success;
    }
    
    public void Dispose()
    {
        _database.Dispose();
    }
}