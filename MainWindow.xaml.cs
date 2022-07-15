using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> AccountList;
        public MainWindow()
        {
            AccountList = new List<Account>();
            InitializeComponent();
            Properties.Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private async void Default_SettingsSaving(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var token in Properties.Settings.Default.TokensArray)
            {
                AccountList.Add(await Account.CreateAccount(token));
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(Properties.Settings.Default.TokensArray.Count == 0)
            {
                Window1 AddTokenWindow = new Window1();
                AddTokenWindow.Show();
            }

            

            
        }

        public async void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            
        }
    }
}
