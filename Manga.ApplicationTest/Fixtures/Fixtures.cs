namespace Manga.ApplicationTest.Fixtures;

public static partial class Fixtures
{
    public static string Name = "Sakamoto Days";
    public static float Rating = 10;
    public static bool True = true;
    public static bool False = false;

    public static string NameEmpty = string.Empty;

    public static List<Domain.Entities.Manga> Mangas()
    {

        var mangas = new List<Domain.Entities.Manga>()
        {
            new Domain.Entities.Manga(Guid.Parse("90dcccca-59bf-46fc-8d1c-f1bb7ad2c0c1"), "Sakamoto Days", 10, true),
            new Domain.Entities.Manga(Guid.Parse("90dcccca-59bf-46fc-8d1c-f1bb7ad2c0c1"), "Jujutsu Kaisen", 10, false)
        };
        return mangas;
    }
}