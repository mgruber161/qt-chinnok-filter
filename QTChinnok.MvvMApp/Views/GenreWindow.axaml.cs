namespace QTChinnok.MvvMApp.Views
{
    public partial class GenreWindow : ModelView<Models.Genre, Logic.Models.Base.Genre>
    {
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
