namespace QTChinnok.Logic.Controllers.App
{
    partial class AlbumsController
    {
        internal override IEnumerable<string> Includes => new string[] { nameof(Entities.App.Album.Artist) };
    }
}
