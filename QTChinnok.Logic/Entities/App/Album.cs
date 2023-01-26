using QTChinnok.Logic.Entities.Base;

namespace QTChinnok.Logic.Entities.App
{
    [Table("albums")]
    public class Album : VersionEntity
    {
        [Key]
        [Column("AlbumId")]
        public override IdType Id { get => base.Id; internal set => base.Id = value; }
        public IdType ArtistId { get; set; }
        [MaxLength(160)]
        public string Title { get; set; } = string.Empty;

        #region navigation properties
        public Artist? Artist { get; set; }
        public List<Track> Tracks { get; set; } = new();
        public List<MusicCollection> MusicCollections { get; set; } = new();
        #endregion  navigation properties
    }
}
