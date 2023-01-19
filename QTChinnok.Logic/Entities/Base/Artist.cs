
namespace QTChinnok.Logic.Entities.Base
{
    [Table("artists")]
    public class Artist : VersionEntity
    {
        [Key]
        [Column("ArtistId")]
        public override int Id { get => base.Id; internal set => base.Id = value; }
        [MaxLength(120)]
        public string? Name { get; set; }

    }
}
