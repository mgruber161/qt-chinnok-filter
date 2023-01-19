namespace QTChinnok.Logic.Entities.Base
{
    [Table("genres")]
    public class Genre : VersionEntity
    {
        [Column("GenreId")]
        public override int Id { get => base.Id; internal set => base.Id = value; }
        [MaxLength(120)]
        public string? Name { get; set; }
    }
}
