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
using Microsoft.EntityFrameworkCore;
using System.Windows.Navigation;


namespace movie_program
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            using (ApplicationConnect context = new ApplicationConnect())
            {
                DGrid.ItemsSource = context.Tools.ToList();
            }
        }

        private void Button_Redact(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Edit redact = new Edit((sender as Button).DataContext as Tools);
                redact.Show();
                this.Hide();
            }
        }

         private void Button_Add(object sender, RoutedEventArgs e)
         {
            Edit edit = new Edit(null);
            edit.Show();
              this.Hide();
         }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить фильм?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) 
            {
                using (ApplicationConnect db = new ApplicationConnect())
                {
                    var сurrentUser1 = DGrid.SelectedItem as Tools;
                    db.Tools.Remove(сurrentUser1);
                    db.SaveChanges();
                    DGrid.ItemsSource = db.Tools.ToList();
                    MessageBox.Show("Удалено");
                }
               
            }
                
        }

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
