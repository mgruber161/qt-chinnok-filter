using Avalonia.Controls;

namespace QTChinnok.MvvMApp.Views
{
    public partial class ArtistWindow : Window
    {
        public ViewModels.ArtistViewModel ViewModel { get; private set; }
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
