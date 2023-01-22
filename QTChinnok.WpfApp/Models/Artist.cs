namespace QTChinnok.WpfApp.Models
{
    public class Artist
    {
        public Artist()
        {

        }
        public Artist(Logic.Models.Base.Artist entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
