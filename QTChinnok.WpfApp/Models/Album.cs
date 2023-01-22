namespace QTChinnok.WpfApp.Models
{
    public class Album
    {
        public Album()
        {

        }
        public Album(Logic.Models.App.Album entity)
        {
            Id = entity.Id;
            ArtistId = entity.ArtistId;
            Title = entity.Title;
            ArtistName = entity.Artist?.Name ?? string.Empty;
        }
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
    }
}
