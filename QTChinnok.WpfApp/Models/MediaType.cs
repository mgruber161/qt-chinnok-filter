namespace QTChinnok.WpfApp.Models
{
    public class MediaType
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
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
