using CommonBase.Extensions;
using QTChinnok.MvvMApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QTChinnok.MvvMApp.ViewModels
{
    using TGenre = Models.Genre;

    public class GenreViewModel : BaseViewModel
    {
        #region fields
        private TGenre? _model;
        #endregion fields

        #region properties
        public TGenre Model
        {
            get => _model ??= new TGenre();
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Id
        {
            get => Model.Id;
            set => Model.Id = value;
        }
        public string? Name
        {
            get => Model.Name;
            set => Model.Name = value ?? string.Empty;
        }
        #endregion properties

        #region commands
        public ICommand CommandSave => RelayCommand.Create(p => Save());
        public ICommand CommandClose => RelayCommand.Create(p => Close());
        #endregion commands

        #region methods
        private async void Save()
        {
            bool error = false;
            string errorMessage = string.Empty;

            using var ctrl = new Logic.Controllers.Base.GenresController();

            Task.Run(async () =>
            {
                try
                {
                    var entity = ctrl.Create();

                    entity.CopyFrom(Model);
                    if (Model.Id == 0)
                    {
                        await ctrl.InsertAsync(entity).ConfigureAwait(false);
                    }
                    else
                    {
                        await ctrl.UpdateAsync(entity).ConfigureAwait(false);
                    }
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
        #endregion methods
    }
}
