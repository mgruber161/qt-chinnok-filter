namespace QTChinnok.Logic.Entities.Base
{
    [Table("media_types")]
    public class MediaType : VersionEntity
    {
        [Key]
        [Column("MediaTypeId")]
        public override int Id { get => base.Id; internal set => base.Id = value; }
        [MaxLength(120)]
        public string? Name { get; set; }
    }
}
