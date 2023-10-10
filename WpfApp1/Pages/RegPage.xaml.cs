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
using WpfApp1.Models;
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = PasswordTb.Text.Trim();
            var user = App.bd.Employees.FirstOrDefault(x => x.Login == login );
            if(user == null) 
            {
                Employees newemployee = new Employees
                {
                    Login = login,
                    Password = password,
                    Name = NameTb.Text.Trim(),
                    LastName = SurNameTb.Text.Trim(),
                    RoleId = 1,
                };
                App.bd.SaveChanges();
                MessageBox.Show("пользователь создан");
                NavigationService.Navigate(new AutoPage());

            }
            else MessageBox.Show("пользователь существует");
        }
    }
}
