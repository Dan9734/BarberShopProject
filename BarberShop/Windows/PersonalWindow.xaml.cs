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
    /// Логика взаимодействия для PersonalWindow.xaml
    /// </summary>
    public partial class PersonalWindow : Window
    {
        List<Personnel> personnels = new List<Personnel>();
        List<string> ForSort = new List<string>()
        {
            "По умолчанию","По фамилия","По имени","По телефону","По специальности"
        };
        public PersonalWindow()
        {
            InitializeComponent();
            AllPersonal.ItemsSource = context.Personnel.ToList();
            Sort.ItemsSource = ForSort;
            Sort.SelectedIndex = 0;
            Filter();
        }
        private void Filter()
        {
            personnels = ClassEntities.context.Personnel.ToList();
            personnels = personnels.Where(i => i.INFO.Contains(Search.Text)).ToList();
            

            switch (Sort.SelectedIndex)
            {
                case 0:
                    personnels = personnels.OrderBy(i => i.IdPersonnel).ToList();
                    break;
                case 1:
                    personnels = personnels.OrderBy(i => i.FirstName).ToList();
                    break;
                case 2:
                    personnels = personnels.OrderBy(i => i.LastName).ToList();
                    break;
                case 3:
                    personnels = personnels.OrderBy(i => i.Phone).ToList();
                    break;
                case 4:
                    personnels = personnels.OrderBy(i => i.IdSpecialization).ToList();
                    break;
                default:
                    personnels = personnels.OrderBy(i => i.IdPersonnel).ToList();
                    break;
            }

            if (AllPersonal == null)
            {
                MessageBox.Show("Такой записи нет");
            }
            AllPersonal.ItemsSource = personnels;
        }
        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            this.Close();
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter(); 
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if (AllPersonal.SelectedItem is Personnel personnel)
            {
                var resMAss = MessageBox.Show($"Вы хотите изменить пользователя {personnel.LastName}  {personnel.FirstName}", "Предупреждение", MessageBoxButton.YesNo);
                if (resMAss == MessageBoxResult.Yes)
                {
                    this.Hide();
                    AddWindow addWindow = new AddWindow(personnel);
                    PersonnelData.IdPersonnel = personnel.IdPersonnel;
                    addWindow.ShowDialog();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Вы не выбрали пользователя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (AllPersonal.SelectedItem is Personnel personnel)
            {
                var resMass = MessageBox.Show($"Вы хотите удалить пользователя {personnel.LastName}  {personnel.FirstName}", "Предупреждение", MessageBoxButton.YesNo);
                if (resMass == MessageBoxResult.Yes)
                {
                    context.Personnel.Remove(context.Personnel.Where(i => i.IdPersonnel == personnel.IdPersonnel).FirstOrDefault());
                    context.SaveChanges();
                    AllPersonal.ItemsSource = context.Personnel.ToList();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Вы не выбрали пользователя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AllPersonal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
