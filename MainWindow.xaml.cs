using System.Windows;

namespace Demka
{
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new WindowViewModel(this);
        }

    }
}
