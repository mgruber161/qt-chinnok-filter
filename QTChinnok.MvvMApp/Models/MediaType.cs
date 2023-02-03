namespace QTChinnok.MvvMApp.Models
{
    public class MediaType : ModelObject
    {
        public MediaType()
        {

        }
        public MediaType(Logic.Models.Base.MediaType entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public MediaType(Logic.Entities.Base.MediaType entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public string Name { get; set; } = string.Empty;
        public override string ToString() => $"{Name}";
    }
}
