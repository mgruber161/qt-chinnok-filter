namespace QTChinnok.Logic.Entities.App
{
    [Table("musiccollections")]
    [Index(nameof(Name), IsUnique = true)]
    public class MusicCollection : VersionEntity
    {
        [Key]
        [Column("MusicCollectionId")]
        public override int Id { get => base.Id; internal set => base.Id = value; }
        [MaxLength(160)]
        public string Name { get; set; } = string.Empty;

        #region navigation properties
        public List<Album> Albums { get; set; } = new();
        #endregion navigation properties
    }
}
