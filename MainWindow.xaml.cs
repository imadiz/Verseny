//try-catch
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Verseny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ViewModel VM;
        public MainWindow()
        {
            InitializeComponent();
            VM = this.DataContext as ViewModel;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl MainControl = sender as TabControl;
            switch ((MainControl.SelectedItem as TabItem).Name)
            {
                case "Create_Game":
                    this.Width = 400;
                    this.Height = 450;
                    break;
                case "Create_Bet":
                    this.Width = 600;
                    this.Height = 450;
                    break;
            }
        }

        private void txt_bettingpoints_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
