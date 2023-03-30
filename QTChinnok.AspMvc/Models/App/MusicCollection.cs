using QTChinnok.Logic.Entities.App;

namespace QTChinnok.AspMvc.Models.App
{
    public class MusicCollection : VersionModel
    {
        public string Name { get; set; } = string.Empty;

        public List<App.Album> Albums { get; set; } = new();
        public List<App.Album> AddAlbums { get; set; } = new();

        public override string ToString()
        {
            return $"{Name}";
        }
        public static MusicCollection Create(Logic.Models.App.MusicCollection entity)
        {
            return new MusicCollection
            {
                Id = entity.Id,
                Name = entity.Name,
                Albums = entity.Albums.Select(e => Models.App.Album.Create(e)).ToList(),
            };
        }
    }
}
