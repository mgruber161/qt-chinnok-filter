using Avalonia.Controls;

namespace QTChinnok.MvvMApp.Views
{
    public partial class ArtistWindow : ModelView<Models.Artist, Logic.Models.Base.Artist>
    {
        public ArtistWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new ViewModels.ArtistViewModel()
            {
                Window = this,
            };
        }
    }
}
