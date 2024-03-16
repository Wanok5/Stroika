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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace movie_program
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registration(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Avtoriz Tools = new Avtoriz();
                avtoriz.Name = Text_name.Text;
                avtoriz.Login = Text_login.Text;
                avtoriz.Password = Password_Box2.Password;

                db.Add(avtoriz);
               


                MainWindow avtoriz = new MainWindow();
                avtoriz.Show();
                this.Hide();
            }
        }
    }
}
