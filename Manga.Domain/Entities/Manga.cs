namespace Manga.Domain.Entities;

public class Manga
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
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
}