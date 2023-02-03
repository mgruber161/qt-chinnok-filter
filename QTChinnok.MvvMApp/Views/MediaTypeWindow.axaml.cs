namespace QTChinnok.MvvMApp.Views
{
    public partial class MediaTypeWindow : ModelView<Models.MediaType, Logic.Models.Base.MediaType>
    {
        public MediaTypeWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new ViewModels.MediaTypeViewModel()
            {
                Window = this,
            };
        }
    }
}