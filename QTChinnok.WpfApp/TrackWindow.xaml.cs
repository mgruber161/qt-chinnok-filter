using System.Windows;

namespace QTChinnok.WpfApp
{
    /// <summary>
    /// Interaction logic for TrackWindow.xaml
    /// </summary>
    public partial class TrackWindow : Window
    {
        public TrackWindow()
        {
            InitializeComponent();
            ViewModel.Window = this;
        }
    }
}
