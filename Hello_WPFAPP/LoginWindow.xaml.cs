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

namespace Hello_WPFAPP
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // ta giả đò làm đăng nhập:
            //Nếu thành công thì vào Main Window 
            //Nếu thất bại thì thông báo failed
            if(txtUsername.Text=="obama" && 
                txtPassword.Password=="123")
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                //đóng màn hình đăng nhập:
                Close();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại rồi Thím!");
            } 
                
        }
    }
}
