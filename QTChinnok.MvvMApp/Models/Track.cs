
namespace QTChinnok.MvvMApp.Models
{
    public class Track : ModelObject
    {
        public Track()
        {
        }
        public Track(Logic.Models.App.Track entity)
        {
            Id = entity.Id;
            AlbumId = entity.AlbumId;
            GenreId = entity.GenreId;
            MediaTypeId = entity.MediaTypeId;
            Name = entity.Name;
            Composer = entity.Composer ?? string.Empty;
        }
        public int? AlbumId { get; set; }
        public int? GenreId { get; set; }
        public int MediaTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Composer { get; set; } = string.Empty;
        public override string ToString() => $"{Name}-{Composer}";
    }
}
