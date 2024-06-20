namespace Manga.DomainTest.Entities;

public class MangaTest
{
    [Fact]
    public void Should_Create_Manga_In_Static_Method_Create()
    {
        
        //Act
        var create = Manga.Domain.Entities.Manga.
            Create
            (Fixtures.Fixtures.Name,
            Fixtures.Fixtures.Rating,
            Fixtures.Fixtures.True);
        
        //Assert
        Assert.NotNull(create);
        Assert.Equal(Fixtures.Fixtures.Name, create.Name);
        Assert.Equal(Fixtures.Fixtures.Rating, create.Rating);
        Assert.Equal(Fixtures.Fixtures.True, create.Read);
        Assert.NotEqual(create.Id, Guid.Empty);
        Assert.IsType<Guid>(create.Id);
    }

    [Fact]
    public void Should_Return_Null_When_Create_Manga_Without_Name()
    {
       
        //Act
        var create = Manga.Domain.Entities.Manga
            .Create(Fixtures.Fixtures.NameEmpty,
                Fixtures.Fixtures.Rating,
                Fixtures.Fixtures.False);
        
        Assert.Null(create);
    }

    [Fact]
    public void Should_Change_Manga_To_Read_True()
    {
        //Arrange
        var manga = new Domain.Entities.Manga();
        
        //Act
        var change = manga.ChangeReadMangaTrue(Fixtures.Fixtures.True);

        //Assert
        Assert.IsType<bool>(change);
        Assert.Equal(change, Fixtures.Fixtures.True);
    }

    [Fact]
    public void Should_Change_Manga_To_Read_False()
    {
        //Arrange
        var manga = new Domain.Entities.Manga();
        
        //Act
        var change = manga.ChangeReadMangaFalse(Fixtures.Fixtures.False);

        //Assert
        Assert.IsType<bool>(change);
        Assert.Equal(change, Fixtures.Fixtures.False);
    }
}