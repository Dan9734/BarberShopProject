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

namespace BarberShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ServicesWindow servicesWindow = new ServicesWindow();
            servicesWindow.ShowDialog();
            this.Close();
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RecordWindow recordWindow = new RecordWindow();
            recordWindow.ShowDialog();
            this.Close();
        }

        private void Personal_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PersonalWindow personalWindow = new PersonalWindow();
            personalWindow.ShowDialog();
            this.Close();
        }

        private void Stuff_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            StuffWindow stuffWindow = new StuffWindow();
            stuffWindow.ShowDialog();
            this.Close();
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AuthWindow authWindow = new AuthWindow();
            authWindow.ShowDialog();
            this.Close();
        }
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
