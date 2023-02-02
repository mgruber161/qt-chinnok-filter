using Avalonia.Controls;

namespace QTChinnok.MvvMApp.Views
{
    public partial class GenreWindow : Window
    {
        public ViewModels.GenreViewModel ViewModel { get; private set; }
        public GenreWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new ViewModels.GenreViewModel()
            {
                Window = this,
            };
        }
    }
}
