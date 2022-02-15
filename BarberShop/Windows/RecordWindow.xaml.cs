using BarberShop.EF;
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
    /// Логика взаимодействия для RecordWindow.xaml
    /// </summary>
    public partial class RecordWindow : Window
    {
        public RecordWindow()
        {
            InitializeComponent();

            Client.ItemsSource = context.Client.ToList();
            Client.DisplayMemberPath = "DATA";
            Client.SelectedIndex = 0;

            Personel.ItemsSource = context.Personnel.ToList();
            Personel.DisplayMemberPath = "DOPE";
            Personel.SelectedIndex = 0;

            Service.ItemsSource = context.Services.ToList();
            Service.DisplayMemberPath = "NameService";
            Service.SelectedIndex = 0;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Record record = new Record();

            record.idClient = Client.SelectedIndex + 1;
            record.IdPersonnel = Personel.SelectedIndex + 1;
            record.IdServices = Service.SelectedIndex + 1;

            MessageBox.Show("Запись добавлен");
            ClassEntities.context.Record.Add(record);
            ClassEntities.context.SaveChanges();
        }
    }
}
