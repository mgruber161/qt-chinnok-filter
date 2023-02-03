namespace QTChinnok.MvvMApp.Models
{
    public class Artist : ModelObject
    {
        public Artist()
        {

        }
        public Artist(Logic.Models.Base.Artist entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public string Name { get; set; } = string.Empty;

        public override string ToString() => $"{Name}";
    }
}
