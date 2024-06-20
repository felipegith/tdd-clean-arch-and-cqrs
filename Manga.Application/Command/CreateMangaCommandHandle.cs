using Manga.Infrastructure.Interface;
using MediatR;

namespace Manga.Application.Command;

public class CreateMangaCommandHandle : IRequestHandler<CreateMangaCommand, Guid>
{
    private readonly IMangaRepository _mangaRepository;
    private readonly IUnitOfWork _uow;

    public CreateMangaCommandHandle(IMangaRepository mangaRepository, IUnitOfWork uow)
    {
        _mangaRepository = mangaRepository;
        _uow = uow;
    }


    public async Task<Guid> Handle(CreateMangaCommand request, CancellationToken cancellationToken)
    {
        var manga = Manga.Domain.Entities.Manga.Create(request.Name, request.Rating, request.Read);

        if (manga is null)
            return Guid.Empty;

        _mangaRepository.CreateAsync(manga, cancellationToken);

        await _uow.Commit();

        return manga.Id;
    }
}