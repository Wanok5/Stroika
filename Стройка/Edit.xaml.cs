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
namespace movie_program
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private Tools Movie = new Tools();    
        public Edit(Tools selectedMovie)
        {
            InitializeComponent();
            if (selectedMovie != null)
            {
                Movie = selectedMovie;
                
            }
            DataContext = Movie;
            Tools item = DataContext as Tools;
            if (item != null)
            {
                namefilms.Text = item.Название;
                contry.Text = item.Страна производитель;
                compan.Text = item.Компания;
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationConnect db = new ApplicationConnect())
            {
                Tools tools DataContext as Tools;
                if (Movie != null) 
                {
                    Tools.Название = namefilms.Text;
                    Tools.Страна = contry.Text;
                    Tools.Компания = compan.Text;

                    db.Tools.Update(Tools);
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    
                    tools.Название = namefilms.Text;
                    tools.Страна = contry.Text;
                    tools.Компания = compan.Text;
                    db.Add(Tools);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Информация сохранена");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                
               

            }

            

        }
         
    }

}
