using QTChinnok.Logic.Contracts;
using System.Linq;

namespace QTChinnok.MvvMApp.ViewModels
{
    using TModel = Models.Album;
    using TEntity = Logic.Models.App.Album;
    public class AlbumViewModel : ModelViewModel<TModel, TEntity>
    {
        public int ArtistId
        {
            get => Model.ArtistId;
            set => Model.ArtistId = value;
        }
        public string Title
        {
            get => Model.Title;
            set => Model.Title = value;
        }

        public override IDataAccess<TEntity> CreateController()
        {
            return new Logic.Controllers.App.AlbumsController();
        }

        protected override void OnPropertiesChanged(params string[] propertyNames)
        {
            base.OnPropertiesChanged(propertyNames.Union(new string[] { "Id", "Name" }).ToArray());
        }
    }
}
