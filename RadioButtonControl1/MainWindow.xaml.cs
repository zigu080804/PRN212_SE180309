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

namespace RadioButtonControl1
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

        private void btnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhchon = "";
            if (radRatTot.IsChecked == true)
            {
                binhchon = radRatTot.Content + "";
            } else if (radTot.IsChecked == true)
            {
                binhchon = radTot.Content + "";
            }
            else if (radTamDuoc.IsChecked == true)
            {
                binhchon = radTamDuoc.Content + "";
            }
            else if (radKhongTot.IsChecked == true)
            {
                binhchon = radKhongTot.Content + "";
            }
            string gioitinh = "";
            if (radNam.IsChecked == true)
                gioitinh = radNam.Content + "";
            else if (radNu.IsChecked == true)
                gioitinh = radNu.Content + "";

            string infor = "Bạn đã bình chọn hệ thống " + binhchon + Environment.NewLine + "Giới tính của bạn là: " + gioitinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question);
            if (ret == MessageBoxResult.Yes)
            {
            }

        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
