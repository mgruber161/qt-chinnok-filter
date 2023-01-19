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
    using TGenre = Logic.Models.Base.Genre;
    public partial class MainViewModel : BaseViewModel
    {
        #region fields
        private ICommand? _cmdAddGenre;
        private ICommand? _cmdEditGenre;
        private ICommand? _cmdDeleteGenre;

        private string genreFilter = string.Empty;
        private List<TGenre> _genres = new();
        #endregion fields

        #region properties
        public ObservableCollection<TGenre> Genres => new(_genres);
        public string GenreFilter
        {
            get => genreFilter;
            set
            {
                genreFilter = value;
                OnPropertyChanged(nameof(Genres));
            }
        }
        public TGenre? SelectedGenre { get; set; }

        public ICommand CommandAddGenre => RelayCommand.CreateCommand(ref _cmdAddGenre, p => AddGenre());
        public ICommand CommandEditGenre => RelayCommand.CreateCommand(ref _cmdEditGenre, p => EditGenre(), p => SelectedGenre != null);
        public ICommand CommandDeleteGenre => RelayCommand.CreateCommand(ref _cmdDeleteGenre, p => DeleteGenre(), p => SelectedGenre != null);
        #endregion properties

        public MainViewModel()
        {
            OnPropertyChanged(nameof(Genres));
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
        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(Genres))
            {
                Task.Run(LoadGenresAsync);
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }
        private async Task LoadGenresAsync()
        {
            using var ctrl = new Logic.Controllers.Base.GenresController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);
            var result = items.Where(i => i.Name != null && i.Name.Contains(genreFilter, System.StringComparison.CurrentCultureIgnoreCase));

            _genres.Clear();
            _genres.AddRange(result);
            base.OnPropertyChanged(nameof(Genres));
        }
    }
}
//MdEnd
