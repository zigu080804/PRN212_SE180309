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

namespace ListWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
         List<int> dsDulieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiatri.Text);
            dsDulieu.Add(x);
            Hienthidanhsach();
            txtGiatri.Text = "";
        }
        void Hienthidanhsach()
        {
            lstDuLieu.Items.Clear();
            for(int i = 0;i<dsDulieu.Count;i++) 
                {
                int x = dsDulieu[i];
                lstDuLieu.Items.Add(x);
                }
        }

        private void btnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);

            int vt = int.Parse(txtVitriChen.Text);

            dsDulieu.Insert(vt,x);
            Hienthidanhsach();
            txtVitriChen.Text = "";
            txtGiaTriChen.Text = "";
        }

        private void btnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDulieu.Sort();
            Hienthidanhsach();
        }

        private void btnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDulieu.Sort();
            //đảo lại danh sách 
            dsDulieu.Reverse();
            //hiển thị lại danh sách 
            Hienthidanhsach();
        }

        private void btnXoa1phantu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi"
                  , MessageBoxButton.OK); 
                return;
            }
            //xóa phần tử tại vị trí đang chọn:  
            dsDulieu.RemoveAt(lstDuLieu.SelectedIndex);
            Hienthidanhsach();
        }

        private void btnXoanhieuphantu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được", "Thông báo lỗi", MessageBoxButton.OK); 
                return;
            }
            //vòng lặp lấy các phần tử được chọn trên giao diện 
            while (lstDuLieu.SelectedItems.Count > 0)
            {
                //lấy phần tử đầu tiên ra 
                int data = (int)lstDuLieu.SelectedItems[0];
                //xóa khỏi danh sách 
                dsDulieu.Remove(data);
                //xóa dữ liệu trên giao diện 
                lstDuLieu.Items.Remove(data);
            }
        }

        private void btnXoatoanbophantu_Click(object sender, RoutedEventArgs e)
        {
            dsDulieu.Clear();//xóa toàn bộ dữ liệu  
            Hienthidanhsach();
        }
    }
}
