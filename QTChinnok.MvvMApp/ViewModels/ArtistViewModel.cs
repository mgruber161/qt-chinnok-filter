using QTChinnok.Logic.Contracts;
using System.Linq;

namespace QTChinnok.MvvMApp.ViewModels
{
    using TModel = Models.Artist;
    using TEntity = Logic.Models.Base.Artist;
    public class ArtistViewModel : ModelViewModel<TModel, TEntity>
    {
        public string Name 
        {
            get => Model.Name;
            set => Model.Name = value; 
        }

        public override IDataAccess<TEntity> CreateController()
        {
            return new Logic.Controllers.Base.ArtistsController();
        }

        protected override void OnPropertiesChanged(params string[] propertyNames)
        {
            base.OnPropertiesChanged(propertyNames.Union(new string[] { "Id", "Name" }).ToArray());
        }
    }
}
