using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demka
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void AddToken_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.TokensArray.Add(TokenTextBox.Text);
            Properties.Settings.Default.Save();
            var x = Properties.Settings.Default.TokensArray[0];
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }
    }
}
