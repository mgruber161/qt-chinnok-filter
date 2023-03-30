namespace QTChinnok.AspMvc.Models.Base
{
    public class Artist : VersionModel
    {
        public string Name { get; set; } = string.Empty;

        public static Artist Create(Logic.Models.Base.Artist entity)
        {
            return new Artist
            {
                Id = entity.Id,
                Name = entity.Name ?? string.Empty,
            };
        }
    }
}
