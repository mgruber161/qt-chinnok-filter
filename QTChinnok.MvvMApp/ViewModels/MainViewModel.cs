//@CodeCopy
//MdStart
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using QTChinnok.Logic.Contracts;
using QTChinnok.MvvMApp.Views;

namespace QTChinnok.MvvMApp.ViewModels
{
    using TGenreEntity = Logic.Models.Base.Genre;
    using TGenreModel = Models.Genre;

    using TMediaTypeEntity = Logic.Models.Base.MediaType;
    using TMediaTypeModel = Models.MediaType;

    using TArtistEntity = Logic.Models.Base.Artist;
    using TArtistModel = Models.Artist;

    using TAlbumEntity = Logic.Models.App.Album;
    using TAlbumModel = Models.Album;

    using TTrackEntity = Logic.Models.App.Track;
    using TTrackModel = Models.Track;
    public partial class MainViewModel : BaseViewModel
    {
        class GenresViewModel : DelegateViewModel<TGenreModel, TGenreEntity>
        {
            protected override ModelView<TGenreModel, TGenreEntity>? ModelView
            {
                get => new GenreWindow();
            }
            protected override Func<TGenreEntity, TGenreModel> ConvertTo
            {
                get => (e) => new TGenreModel(e);
            }
            protected override Predicate<TGenreEntity> LoadPredicate
            {
                get => (e) => e.Name != null && e.Name.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase);
            }

            public GenresViewModel(BaseViewModel otherViewModel)
                : base(otherViewModel)
            {
            }

            public override IDataAccess<TGenreEntity> CreateController()
            {
                return new Logic.Controllers.Base.GenresController();
            }
        }
        class MediaTypesViewModel : DelegateViewModel<TMediaTypeModel, TMediaTypeEntity>
        {
            protected override ModelView<TMediaTypeModel, TMediaTypeEntity>? ModelView => new MediaTypeWindow();
            protected override Func<TMediaTypeEntity, TMediaTypeModel> ConvertTo => (e) => new TMediaTypeModel(e);
            protected override Predicate<TMediaTypeEntity> LoadPredicate => e => e.Name != null && e.Name.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase);

            public MediaTypesViewModel(BaseViewModel otherViewModel)
                : base(otherViewModel)
            {
            }

            public override IDataAccess<TMediaTypeEntity> CreateController()
            {
                return new Logic.Controllers.Base.MediaTypesController();
            }
        }
        class ArtistsViewModel : DelegateViewModel<TArtistModel, TArtistEntity>
        {
            protected override ModelView<TArtistModel, TArtistEntity>? ModelView => new ArtistWindow();
            protected override Func<TArtistEntity, TArtistModel> ConvertTo => e => new TArtistModel(e);
            protected override Predicate<TArtistEntity> LoadPredicate => e => e.Name != null && e.Name.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase);

            public ArtistsViewModel(BaseViewModel otherViewModel)
                : base(otherViewModel)
            {
            }

            public override IDataAccess<TArtistEntity> CreateController()
            {
                return new Logic.Controllers.Base.ArtistsController();
            }
        }
        class AlbumsViewModel : DelegateViewModel<TAlbumModel, TAlbumEntity>
        {
            protected override ModelView<TAlbumModel, TAlbumEntity>? ModelView => new AlbumWindow();
            protected override Func<TAlbumEntity, TAlbumModel> ConvertTo => e => new TAlbumModel(e);
            protected override Predicate<TAlbumEntity> LoadPredicate => e => e.Title != null && e.Title.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase);

            public AlbumsViewModel(BaseViewModel otherViewModel) : base(otherViewModel)
            {
            }

            public override IDataAccess<TAlbumEntity> CreateController()
            {
                return new Logic.Controllers.App.AlbumsController();
            }
        }
        class TracksViewModel : DelegateViewModel<TTrackModel, TTrackEntity>
        {
            protected override ModelView<TTrackModel, TTrackEntity>? ModelView => new TrackWindow();
            protected override Func<TTrackEntity, TTrackModel> ConvertTo => e => new TTrackModel(e);
            protected override Predicate<TTrackEntity> LoadPredicate => e => (e.Composer != null && e.Composer.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase)
                                                                                || (e.Name.Contains(ModelFilter, StringComparison.CurrentCultureIgnoreCase)));
            public TracksViewModel(BaseViewModel otherViewModel) : base(otherViewModel)
            {
            }

            public override IDataAccess<TTrackEntity> CreateController()
            {
                return new Logic.Controllers.App.TracksController();
            }
        }
        #region fields
        private GenresViewModel _genresViewModel;
        private MediaTypesViewModel _mediaTypesViewModel;
        private ArtistsViewModel _artistsViewModel;
        private AlbumsViewModel _albumsViewModel;
        private TracksViewModel _tracksViewModel;
        #endregion fields

        #region properties
        public TGenreModel[] Genres => _genresViewModel.Models;
        public TMediaTypeModel[] MediaTypes => _mediaTypesViewModel.Models;
        public TArtistModel[] Artists => _artistsViewModel.Models;
        public TAlbumModel[] Albums => _albumsViewModel.Models;
        public TTrackModel[] Tracks => _tracksViewModel.Models;

        public string GenreFilter
        {
            get => _genresViewModel.ModelFilter;
            set
            {
                _genresViewModel.ModelFilter = value;
            }
        }
        public string MediaTypeFilter
        {
            get => _mediaTypesViewModel.ModelFilter;
            set
            {
                _mediaTypesViewModel.ModelFilter = value;
            }
        }
        public string ArtistFilter
        {
            get => _artistsViewModel.ModelFilter;
            set
            {
                _artistsViewModel.ModelFilter = value;
            }
        }
        public string AlbumFilter
        {
            get => _albumsViewModel.ModelFilter;
            set
            {
                _albumsViewModel.ModelFilter = value;
            }
        }
        public string TrackFilter
        {
            get => _tracksViewModel.ModelFilter;
            set
            {
                _tracksViewModel.ModelFilter = value;
            }
        }

        public TGenreModel? SelectedGenre
        {
            get => _genresViewModel.SelectedModel;
            set
            {
                _genresViewModel.SelectedModel = value;
            }
        }
        public TMediaTypeModel? SelectedMediaType
        {
            get => _mediaTypesViewModel.SelectedModel;
            set
            {
                _mediaTypesViewModel.SelectedModel = value;
            }
        }
        public TArtistModel? SelectedArtist
        {
            get => _artistsViewModel.SelectedModel;
            set
            {
                _artistsViewModel.SelectedModel = value;
            }
        }
        public TAlbumModel? SelectedAlbum
        {
            get => _albumsViewModel.SelectedModel;
            set
            {
                _albumsViewModel.SelectedModel = value;
            }
        }
        public TTrackModel? SelectedTrack
        {
            get => _tracksViewModel.SelectedModel;
            set
            {
                _tracksViewModel.SelectedModel = value;
            }
        }
        #endregion properties

        #region commands
        public ICommand CommandAddGenre => _genresViewModel.CommandAddModel;
        public ICommand CommandEditGenre => _genresViewModel.CommandEditModel;
        public ICommand CommandDeleteGenre => _genresViewModel.CommandDeleteModel;

        public ICommand CommandAddMediaType => _mediaTypesViewModel.CommandAddModel;
        public ICommand CommandEditMediaType => _mediaTypesViewModel.CommandEditModel;
        public ICommand CommandDeleteMediaType => _mediaTypesViewModel.CommandDeleteModel;

        public ICommand CommandAddArtist => _artistsViewModel.CommandAddModel;
        public ICommand CommandEditArtist => _artistsViewModel.CommandEditModel;
        public ICommand CommandDeleteArtist => _artistsViewModel.CommandDeleteModel;

        public ICommand CommandAddAlbum => _albumsViewModel.CommandAddModel;
        public ICommand CommandEditAlbum => _albumsViewModel.CommandEditModel;
        public ICommand CommandDeleteAlbum => _albumsViewModel.CommandDeleteModel;

        public ICommand CommandAddTrack => _tracksViewModel.CommandAddModel;
        public ICommand CommandEditTrack => _tracksViewModel.CommandEditModel;
        public ICommand CommandDeleteTrack => _tracksViewModel.CommandDeleteModel;
        #endregion commands

        public MainViewModel()
        {
            _genresViewModel = new(this);
            _mediaTypesViewModel = new(this);
            _artistsViewModel = new(this);
            _albumsViewModel = new(this);
            _tracksViewModel = new(this);
        }
        internal override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            var data = propertyName?.Split("_");

            if (data?.Length == 2)
            {
                var delegatePropName = $"{data[1].Replace("Model", data[0])}";

                base.OnPropertyChanged(delegatePropName);
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }
    }
}
//MdEnd