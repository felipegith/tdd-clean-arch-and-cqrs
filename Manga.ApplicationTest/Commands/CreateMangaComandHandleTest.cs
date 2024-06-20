using Manga.Application.Command;
using Manga.Infrastructure.Interface;
using NSubstitute;

namespace Manga.ApplicationTest.Commands;

public class CreateMangaComandHandleTest
{
    private readonly IMangaRepository _mangaRepository = Substitute.For<IMangaRepository>();
    private readonly IUnitOfWork _uow = Substitute.For<IUnitOfWork>();
    
    [Fact]
    public async Task Handle_Should_Create_Manga_Sucessfully_And_Return_Guid()
    {
        
        var command = new CreateMangaCommand(Fixtures.Fixtures.Name, Fixtures.Fixtures.Rating, Fixtures.Fixtures.True);
        var handle = new CreateMangaCommandHandle(_mangaRepository, _uow);

        //Act
        var result = await handle.Handle(command, default);
        
        //Assert
        Assert.IsType<Guid>(result);
        Assert.NotEqual(result, Guid.Empty);
    }

    [Fact]
    public async Task Handle_Should_Return_Empty_Guid_When_Manga_Name_Is_Empty()
    {
        
        var command = new CreateMangaCommand(Fixtures.Fixtures.NameEmpty, Fixtures.Fixtures.Rating, Fixtures.Fixtures.False);
        var handle = new CreateMangaCommandHandle(_mangaRepository, _uow);
        
        //Act
        var result = await handle.Handle(command, default);

        Assert.IsType<Guid>(result);
        Assert.Equal(result, Guid.Empty);
        
    }
}