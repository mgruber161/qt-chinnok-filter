namespace QTChinnok.WpfApp.Models
{
    public class Genre
    {
        public Genre()
        {

        }
        public Genre(Logic.Models.Base.Genre entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
