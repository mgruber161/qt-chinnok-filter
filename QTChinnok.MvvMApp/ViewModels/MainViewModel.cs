//@CodeCopy
//MdStart
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using QTChinnok.MvvMApp.Views;

namespace QTChinnok.MvvMApp.ViewModels
{
    using TGenre = Models.Genre;
    using TMediaType = Models.MediaType;
    using TAlbum = Models.Album;
    using TTrack = Models.Track;
    public class MainViewModel : BaseViewModel
    {
        #region fields
        private string genreFilter = string.Empty;
        private string mediaTypeFilter = string.Empty;
        private string albumFilter = string.Empty;
        private string trackFilter = string.Empty;
        private string musicCollectionFilter = string.Empty;

        private List<TGenre> _genres = new();
        private List<TMediaType> _mediaTypes = new();
        private List<TAlbum> _albums = new();
        private List<TTrack> _tracks = new();
        private TGenre? _selectedGenre;
        private TMediaType? _selectedMediaType;
        private TAlbum? _selectedAlbum;
        private TTrack? _selectedTrack;

        #endregion fields

        #region properties
        public TGenre[] Genres => _genres.ToArray();
        public TAlbum[] Albums => _albums.ToArray();
        public TTrack[] Tracks => _tracks.ToArray();
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
        public string TrackFilter
        {
            get => trackFilter;
            set
            {
                trackFilter = value;
                OnPropertyChanged(nameof(Tracks));
            }
        }

        public TGenre? SelectedGenre
        {
            get => _selectedGenre;
            set
            {
                _selectedGenre = value;
                OnPropertyChanged(nameof(CommandEditGenre));
                OnPropertyChanged(nameof(CommandDeleteGenre));
             }
        }

        public TMediaType? SelectedMediaType
        {
            get => _selectedMediaType;
            set
            {
                _selectedMediaType = value;
                OnPropertyChanged(nameof(CommandEditMediaType));
                OnPropertyChanged(nameof(CommandDeleteMediaType));
            }
        }

        public TAlbum? SelectedAlbum
        {
            get => _selectedAlbum;
            set
            {
                _selectedAlbum = value;
                OnPropertyChanged(nameof(CommandEditAlbum));
                OnPropertyChanged(nameof(CommandDeleteAlbum));
            }
        }

        public TTrack? SelectedTrack
        {
            get => _selectedTrack;
            set
            {
                _selectedTrack = value;
//                OnPropertyChanged(nameof(CommandEditTrack));
//                OnPropertyChanged(nameof(CommandDeleteTrack));
            }
        }

        #endregion properties

        #region commands
        public ICommand CommandAddGenre => RelayCommand.Create((p) => AddGenre());
        public ICommand CommandEditGenre => RelayCommand.Create(p  => EditGenre(), p => SelectedGenre != null);
        public ICommand CommandDeleteGenre => RelayCommand.Create(p => DeleteGenre(), p => SelectedGenre != null);

        public ICommand CommandAddMediaType => RelayCommand.Create(p => AddMediaType());
        public ICommand CommandEditMediaType => RelayCommand.Create(p => EditMediaType(), p => SelectedMediaType != null);
        public ICommand CommandDeleteMediaType => RelayCommand.Create(p => DeleteMediaType(), p => SelectedMediaType != null);

        public ICommand CommandAddAlbum => RelayCommand.Create(p => AddAlbum());
        public ICommand CommandEditAlbum => RelayCommand.Create(p => EditAlbum(), p => SelectedAlbum != null);
        public ICommand CommandDeleteAlbum => RelayCommand.Create(p => DeleteAlbum(), p => SelectedAlbum != null);

        public ICommand CommandAddTrack => RelayCommand.Create(p => AddTrack());
        #endregion commands

        public MainViewModel()
        {
            OnPropertyChanged(nameof(Genres));
            OnPropertyChanged(nameof(MediaTypes));
            OnPropertyChanged(nameof(Albums));
            OnPropertyChanged(nameof(Tracks));
        }
        protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
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
            else if (propertyName == nameof(Tracks))
            {
                Task.Run(LoadTracksAsync);
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }

        private void AddGenre()
        {
            //GenreWindow window = new();

            //window.ShowDialog();
            //OnPropertyChanged(nameof(Genres));
        }
        private void EditGenre()
        {
            //GenreWindow window = new();

            //window.ViewModel.Model = SelectedGenre!;
            //window.ShowDialog();
            //OnPropertyChanged(nameof(Genres));
        }
        private async void DeleteGenre()
        {
            var result = await MessageBox.ShowAsync(Window, $"Soll der Eintrag '{SelectedGenre?.Name}' gelöscht werden?", "Löschen", MessageBox.MessageBoxButtons.YesNo);
            //var result = MessageBox.Show($"Soll der Eintrag '{SelectedGenre?.Name}' gelöscht werden", "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBox.MessageBoxResult.Yes)
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
                    await MessageBox.ShowAsync(Window, errorMessage, "Löschen", MessageBox.MessageBoxButtons.Ok);
                    //await MessageBox.ShowAsync(Window, errorMessage, "Löschen", MessageBox.MessageBoxButtons.Ok);
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
            //AlbumWindow window = new();

            //window.ShowDialog();
            //OnPropertyChanged(nameof(Albums));
        }
        private void EditAlbum()
        {
            //AlbumWindow window = new();

            //window.ViewModel.Model = SelectedAlbum!;
            //window.ShowDialog();
            //OnPropertyChanged(nameof(Albums));
        }
        private void DeleteAlbum()
        {
            //var result = MessageBox.Show($"Soll der Eintrag '{SelectedAlbum?.Title}' gelöscht werden", "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (result == MessageBoxResult.Yes)
            //{
            //    bool error = false;
            //    string errorMessage = string.Empty;

            //    Task.Run(async () =>
            //    {
            //        try
            //        {
            //            using var ctrl = new Logic.Controllers.App.AlbumsController();

            //            await ctrl.DeleteAsync(SelectedAlbum!.Id).ConfigureAwait(false);
            //            await ctrl.SaveChangesAsync().ConfigureAwait(false);
            //        }
            //        catch (System.Exception ex)
            //        {
            //            error = true;
            //            errorMessage = ex.Message;
            //        }
            //    }).Wait();

            //    if (error)
            //    {
            //        MessageBox.Show(errorMessage, "Löschen", MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //    else
            //    {
            //        OnPropertyChanged(nameof(Albums));
            //    }
            //}
        }

        private void AddTrack()
        {
            //TrackWindow window = new();

            //window.ShowDialog();
            //OnPropertyChanged(nameof(Tracks));
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
        private async Task LoadTracksAsync()
        {
            using var ctrl = new Logic.Controllers.App.TracksController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);
            var result = items.Where(i => i.Name.Contains(trackFilter, System.StringComparison.CurrentCultureIgnoreCase));

            _tracks.Clear();
            _tracks.AddRange(result.Select(i => new TTrack(i)));
            SelectedTrack = null;
            base.OnPropertyChanged(nameof(SelectedTrack));
            base.OnPropertyChanged(nameof(Tracks));
        }

    }
}
//MdEnd
