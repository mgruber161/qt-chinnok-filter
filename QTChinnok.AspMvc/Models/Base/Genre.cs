namespace QTChinnok.AspMvc.Models.Base
{
    public class Genre : VersionModel
    {
        [Display(Name = "Bezeichnung")]
        public required string Name { get; set; }
        public static Genre Create(Logic.Models.Base.Genre genre)
        {
            return new Genre
            {
                Id = genre.Id,
                Name = genre.Name ?? string.Empty,
            };
        }
    }
}
