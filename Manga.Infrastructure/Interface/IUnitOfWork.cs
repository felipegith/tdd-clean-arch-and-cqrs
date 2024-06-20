namespace Manga.Infrastructure.Interface;

public interface IUnitOfWork
{
    Task<bool> Commit();
}