using Microsoft.EntityFrameworkCore;
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

namespace movie_program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vchod(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                var currentUser = db.Avtoriz.FirstOrDefault(p => p.Login == TextLogin.Text && p.Password == PassBox.Password);

                if (currentUser != null)
                {
                    Avtoriz.currentUser = currentUser;

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("LOL");
                }
            }
           
        }

       
        private void regis(object sender, RoutedEventArgs e)
        {
            Registration regist = new Registration();
            regist.Show();
            this.Hide();
        }

        private void TextLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
    
}
