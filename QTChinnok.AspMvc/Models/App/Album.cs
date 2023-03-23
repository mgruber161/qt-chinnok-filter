namespace QTChinnok.AspMvc.Models.App
{
    public class Album : VersionModel
    {
        public string Title { get; set; } = string.Empty;
        public static Album Create(Logic.Models.App.Album entity)
        {
            return new Album
            {
                Id = entity.Id,
                Title = entity.Title,
            };
        }
    }
}
