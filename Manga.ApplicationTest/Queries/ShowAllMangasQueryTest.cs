using Manga.Application.Query;
using Manga.Infrastructure.Interface;
using NSubstitute;

namespace Manga.ApplicationTest.Queries;

public class ShowAllMangasQueryTest
{
    private readonly IMangaRepository _mangaRepository = Substitute.For<IMangaRepository>();
    
    [Fact]
    public async Task Query_Should_Return_A_List_Of_Mangas()
    {
        //Arrange
        var query = new ShowAllMangaQuery();
        _mangaRepository.GetAllAsync(default).Returns(Fixtures.Fixtures.Mangas());
        var handle = new ShowAllMangaQueryHandle(_mangaRepository);
        
        //Act
        var result = await handle.Handle(query, default);
        
        //Assert
        Assert.NotEmpty(result);
        Assert.All(result, item => Assert.True(!string.IsNullOrWhiteSpace(item.Name)));
      
    }
}