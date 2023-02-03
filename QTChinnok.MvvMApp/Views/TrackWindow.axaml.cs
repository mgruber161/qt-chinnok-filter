namespace QTChinnok.MvvMApp.Views
{
    public partial class TrackWindow : ModelView<Models.Track, Logic.Models.App.Track>
    {
        public TrackWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new ViewModels.TrackViewModel()
            {
                Window = this,
            };
        }
    }
}
