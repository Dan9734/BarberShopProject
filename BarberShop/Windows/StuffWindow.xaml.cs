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
using static BarberShop.ClassEntities;

namespace BarberShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для StuffWindow.xaml
    /// </summary>
    public partial class StuffWindow : Window
    {
        public StuffWindow()
        {
            InitializeComponent();
            AllStuff.ItemsSource = context.Stuff.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow  mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
