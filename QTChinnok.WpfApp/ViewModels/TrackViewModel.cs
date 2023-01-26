using QTChinnok.WpfApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QTChinnok.WpfApp.ViewModels
{
    using TMediaType = Models.MediaType;
    using TTrack = Models.Track;

    public class TrackViewModel : BaseViewModel
    {
        private ICommand? _cmdSave;
        private ICommand? _cmdClose;

        private List<TMediaType> _mediaTypes = new();

        private TTrack? _model;

        public TMediaType[] MediaTypes => _mediaTypes.ToArray();

        public ICommand CommandSave => RelayCommand.CreateCommand(ref _cmdSave, p => Save());
        public ICommand CommandClose => RelayCommand.CreateCommand(ref _cmdClose, p => Close());

        public TrackViewModel()
        {
            OnPropertyChanged(nameof(MediaTypes));
        }
        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(MediaTypes))
            {
                Task.Run(LoadMediaTypesAsync);
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }
        public TTrack Model
        {
            get => _model ??= new TTrack();
            set => _model = value;
        }

        public int Id
        {
            get => Model.Id;
            set => Model.Id = value;
        }
        public int? GenreId
        {
            get => Model.GenreId;
            set => Model.GenreId = value;
        }
        public int? AlbumId
        {
            get => Model.AlbumId;
            set => Model.AlbumId = value;
        }
        public int MediaTypeId
        {
            get => Model.MediaTypeId;
            set => Model.MediaTypeId = value;
        }
        public string Name
        {
            get => Model.Name;
            set => Model.Name = value;
        }

        public string Composer
        {
            get => Model.Composer;
            set => Model.Composer = value;
        }

        private async Task LoadMediaTypesAsync()
        {
            using var ctrl = new Logic.Controllers.Base.MediaTypesController();
            var items = await ctrl.GetAllAsync().ConfigureAwait(false);

            _mediaTypes.Clear();
            _mediaTypes.AddRange(items.OrderBy(e => e.Name).Select(e => new TMediaType(e)));

            if (MediaTypeId == 0 && _mediaTypes.Any())
            {
                MediaTypeId = _mediaTypes.First().Id;
            }
            base.OnPropertyChanged(nameof(MediaTypeId));
            base.OnPropertyChanged(nameof(MediaTypes));
        }

        private void Save()
        {
            bool error = false;
            string errorMessage = string.Empty;

            Task.Run(async () =>
            {
                try
                {
                    using var ctrl = new Logic.Controllers.App.TracksController();

                    if (Id == 0)
                    {
                        var entity = ctrl.Create();

                        entity.CopyFrom(Model);
                        await ctrl.InsertAsync(entity).ConfigureAwait(false);
                    }
                    else
                    {
                        var entity = await ctrl.GetByIdAsync(Model.Id).ConfigureAwait(false);

                        if (entity != null)
                        {
                            entity.CopyFrom(Model);
                            await ctrl.UpdateAsync(entity).ConfigureAwait(false);
                        }
                    }
                    await ctrl.SaveChangesAsync().ConfigureAwait(false);
                }
                catch (System.Exception ex)
                {
                    error = true;
                    errorMessage = ex.Message;
                    throw;
                }
            }).Wait();

            if (error)
            {
                MessageBox.Show(errorMessage, "Speichern", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Close();
            }
        }
        private void Close()
        {
            Window?.Close();
        }
    }
}
