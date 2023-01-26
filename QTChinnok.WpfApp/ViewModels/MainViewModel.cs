//@CustumCode
//MdStart
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace QTChinnok.WpfApp.ViewModels
{
    using TGenre = Models.Genre;
    using TMediaType = Models.MediaType;
    using TAlbum = Models.Album;
    public partial class MainViewModel : BaseViewModel
    {
        #region fields
        private ICommand? _cmdAddGenre;
        private ICommand? _cmdEditGenre;
        private ICommand? _cmdDeleteGenre;

        private ICommand? _cmdAddMediaType;
        private ICommand? _cmdEditMediaType;
        private ICommand? _cmdDeleteMediaType;

        private ICommand? _cmdAddAlbum;
        private ICommand? _cmdEditAlbum;
        private ICommand? _cmdDeleteAlbum;

        private string genreFilter = string.Empty;
        private string mediaTypeFilter = string.Empty;
        private string albumFilter = string.Empty;
        private List<TGenre> _genres = new();
        private List<TMediaType> _mediaTypes = new();
        private List<TAlbum> _albums = new();
        #endregion fields

        #region properties
        public TGenre[] Genres => _genres.ToArray();
        public TAlbum[] Albums => _albums.ToArray();
        public TMediaType[] MediaTypes => _mediaTypes.ToArray();
        public string GenreFilter
        {
            get => genreFilter;
            set
            {
                genreFilter = value;
                OnPropertyChanged(nameof(Genres));
            }
        }
        public string MediaTypeFilter
        {
            get => mediaTypeFilter;
            set
            {
                mediaTypeFilter = value;
                OnPropertyChanged(nameof(MediaTypes));
            }
        }
        public string AlbumFilter
        {
            get => albumFilter;
            set
            {
                albumFilter = value;
                OnPropertyChanged(nameof(Albums));
            }
        }
        public TGenre? SelectedGenre { get; set; }
        public TMediaType? SelectedMediaType { get; set; }
        public TAlbum? SelectedAlbum { get; set; }

        public ICommand CommandAddGenre => RelayCommand.CreateCommand(ref _cmdAddGenre, p => AddGenre());
        public ICommand CommandEditGenre => RelayCommand.CreateCommand(ref _cmdEditGenre, p => EditGenre(), p => SelectedGenre != null);
        public ICommand CommandDeleteGenre => RelayCommand.CreateCommand(ref _cmdDeleteGenre, p => DeleteGenre(), p => SelectedGenre != null);

        public ICommand CommandAddMediaType => RelayCommand.CreateCommand(ref _cmdAddMediaType, p => AddMediaType());
        public ICommand CommandEditMediaType => RelayCommand.CreateCommand(ref _cmdEditMediaType, p => EditMediaType(), p => SelectedMediaType != null);
        public ICommand CommandDeleteMediaType => RelayCommand.CreateCommand(ref _cmdDeleteMediaType, p => DeleteMediaType(), p => SelectedMediaType != null);

        public ICommand CommandAddAlbum => RelayCommand.CreateCommand(ref _cmdAddAlbum, p => AddAlbum());
        public ICommand CommandEditAlbum => RelayCommand.CreateCommand(ref _cmdEditAlbum, p => EditAlbum(), p => SelectedAlbum != null);
        public ICommand CommandDeleteAlbum => RelayCommand.CreateCommand(ref _cmdDeleteAlbum, p => DeleteAlbum(), p => SelectedAlbum != null);

        #endregion properties

        public MainViewModel()
        {
            OnPropertyChanged(nameof(Genres));
            OnPropertyChanged(nameof(MediaTypes));
            OnPropertyChanged(nameof(Albums));
        }
        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(Genres))
            {
                Task.Run(LoadGenresAsync);
            }
            else if (propertyName == nameof(MediaTypes))
            {
                Task.Run(LoadMediaTypesAsync);
            }
            else if (propertyName == nameof(Albums))
            {
                Task.Run(LoadAlbumsAsync);
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }

        private void AddGenre()
        {
            GenreWindow window = new();

            window.ShowDialog();
            OnPropertyChanged(nameof(Genres));
        }
        private void EditGenre()
        {
            GenreWindow window = new();

            window.ViewModel.Model = SelectedGenre!;
            window.ShowDialog();
            OnPropertyChanged(nameof(Genres));
        }
        private void DeleteGenre()
        {
            var result = MessageBox.Show($"Soll der Eintrag '{SelectedGenre?.Name}' gelöscht werden", "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                bool error = false;
                string errorMessage = string.Empty;

                Task.Run(async () =>
                {
                    try
                    {
                        using var ctrl = new Logic.Controllers.Base.GenresController();

                        await ctrl.DeleteAsync(SelectedGenre!.Id).ConfigureAwait(false);
                        await ctrl.SaveChangesAsync().ConfigureAwait(false);
                    }
                    catch (System.Exception ex)
                    {
                        error = true;
                        errorMessage = ex.Message;
                    }
                }).Wait();

                if (error)
                {
                    MessageBox.Show(errorMessage, "Löschen", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    OnPropertyChanged(nameof(Genres));
                }
            }
        }

        private void AddMediaType()
        {
        }
        private void EditMediaType()
        {
        }
        private void DeleteMediaType()
        {
        }

        private void AddAlbum()
        {
            AlbumWindow window = new();

            window.ShowDialog();
            OnPropertyChanged(nameof(Albums));
        }
        private void EditAlbum()
        {
            AlbumWindow window = new();

            window.ViewModel.Model = SelectedAlbum!;
            window.ShowDialog();
            OnPropertyChanged(nameof(Albums));
        }
        private void DeleteAlbum()
        {
            var result = MessageBox.Show($"Soll der Eintrag '{SelectedAlbum?.Title}' gelöscht werden", "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                bool error = false;
                string errorMessage = string.Empty;

                Task.Run(async () =>
                {
                    try
                    {
                        using var ctrl = new Logic.Controllers.App.AlbumsController();

                        await ctrl.DeleteAsync(SelectedAlbum!.Id).ConfigureAwait(false);
                        await ctrl.SaveChangesAsync().ConfigureAwait(false);
                    }
                    catch (System.Exception ex)
                    {
                        error = true;
                        errorMessage = ex.Message;
                    }
                }).Wait();

                if (error)
                {
                    MessageBox.Show(errorMessage, "Löschen", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    OnPropertyChanged(nameof(Albums));
                }
            }
        }

        private async Task LoadGenresAsync()
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);
            var result = items.Where(i => i.Name != null && i.Name.Contains(genreFilter, System.StringComparison.CurrentCultureIgnoreCase));

            _genres.Clear();
            _genres.AddRange(result.Select(i => new TGenre(i)));
            SelectedGenre = null;
            base.OnPropertyChanged(nameof(SelectedGenre));
            base.OnPropertyChanged(nameof(Genres));
        }
        private async Task LoadMediaTypesAsync()
        {
            using var ctrl = new Logic.Controllers.Base.MediaTypesController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);
            var result = items.Where(i => i.Name != null && i.Name.Contains(mediaTypeFilter, System.StringComparison.CurrentCultureIgnoreCase));

            _mediaTypes.Clear();
            _mediaTypes.AddRange(result.Select(i => new TMediaType(i)));
            SelectedMediaType = null;
            base.OnPropertyChanged(nameof(SelectedMediaType));
            base.OnPropertyChanged(nameof(MediaTypes));
        }
        private async Task LoadAlbumsAsync()
        {
            using var ctrl = new Logic.Controllers.App.AlbumsController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);
            var result = items.Where(i => i.Title.Contains(albumFilter, System.StringComparison.CurrentCultureIgnoreCase)
                                       || i.Artist!.Name!.Contains(albumFilter, System.StringComparison.CurrentCultureIgnoreCase));

            _albums.Clear();
            _albums.AddRange(result.Select(i => new TAlbum(i)));
            SelectedAlbum = null;
            base.OnPropertyChanged(nameof(SelectedAlbum));
            base.OnPropertyChanged(nameof(Albums));
        }
    }
}
//MdEnd
