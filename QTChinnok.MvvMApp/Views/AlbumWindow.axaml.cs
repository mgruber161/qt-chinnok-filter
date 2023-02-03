namespace QTChinnok.MvvMApp.Views
{
    public partial class AlbumWindow : ModelView<Models.Album, Logic.Models.App.Album>
    {
        public AlbumWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new ViewModels.AlbumViewModel()
            {
                Window = this,
            };
        }
    }
}
