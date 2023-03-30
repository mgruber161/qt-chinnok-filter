namespace QTChinnok.AspMvc.Models.App
{
    public class Album : VersionModel
    {
        public int ArtistId { get; set; }
        public string Title { get; set; } = string.Empty;

        public Base.Artist? Artist { get; set; }
        public List<Base.Artist> Artists { get; set; } = new();

        public override string ToString()
        {
            return $"{Title} - {Artist?.Name}";
        }
        public static Album Create(Logic.Models.App.Album entity)
        {
            return new Album
            {
                Id = entity.Id,
                ArtistId = entity.ArtistId,
                Title = entity.Title,
                Artist = entity.Artist != null ? Base.Artist.Create(entity.Artist) : null,
            };
        }
    }
}
