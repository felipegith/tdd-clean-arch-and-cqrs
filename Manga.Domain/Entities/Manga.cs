namespace Manga.Domain.Entities;

public class Manga
{
    public Manga()
    {
        
    }
    public Manga(Guid id, string name, float rating, bool read)
    {
        Id = id;
        Name = name;
        Rating = rating;
        Read = read;
    }

    public Guid Id { get; private set; }
    public string Name { get;  set; }
    public float Rating { get; private set; }
    public bool Read { get; private set; }

    public static Manga Create(string name, float rating, bool read)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            var manga = new Manga()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Rating = rating,
                Read = read
            };

            return manga;
        }

        return null;
    }

    public bool ChangeReadMangaTrue(bool read)
    {
        if (read)
        {
            Read = read;
            return Read;
        }

        return Read;
    }
    
    public bool ChangeReadMangaFalse(bool read)
    {
        if (!read)
        {
            Read = read;

            return Read;
        }

        return Read;
    }
}