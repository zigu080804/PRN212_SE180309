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

namespace XuLyChuoiWPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           KhoaControl(true);
        }

        void KhoaControl(bool b)
        {
            btnDem.IsEnabled = !b;
            btnDemso.IsEnabled = !b;
            btnDemkitu.IsEnabled = !b;
            btnIn.IsEnabled = !b;
            btnInna.IsEnabled = !b;
            btnInso.IsEnabled = !b;
            btnInthuong.IsEnabled = !b;

        }
        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            KhoaControl(false);
            txtNhap.Text = "";
            txtXuat.Text = "";
            txtNhap.Focus();
        }
        private void btnIn_click(object sender, RoutedEventArgs e)
        {
            txtXuat.Text = txtNhap.Text.ToUpper();
        }
        private void btnInthuong_click(object sender, RoutedEventArgs e)
        {
            txtXuat.Text = txtNhap.Text.ToLower();
        }
        private void btnDemkitu_Click(object sender, RoutedEventArgs e)
        {
            int sokitu = txtNhap.Text
                .Count(c=>char.IsLower(c));
            txtXuat.Text = "Có " + sokitu + " kí tự in thường ";
        }

        private void btnInna_Click(object sender, RoutedEventArgs e)
        {
            char[] arr = txtNhap.Text
                .Where(c=> char.IsLetter(c))
                .Select(c=>char.ToLower(c)).ToArray();
            char[] arrNA = { 'a', 'ă', 'â', 'e', 'ê', 'i', 'o', 'ô', 'ơ', 'u', 'ư', 'y' };
            int soNA = arr.Count(c => arrNA.Contains(c));
            int soPA = arr.Length - soNA;
            txtXuat.Text = "Chuỗi có " + soNA + " số nguyên âm, và có " +
soPA + " số phụ âm";
        }

        private void btnInso_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = txtNhap.Text.Split(' ');
            txtXuat.Text = "";
            foreach (string word in arr)
                txtXuat.AppendText(word + "\n");
        }

        private void btnDemso_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = txtNhap.Text.Split(new char[] { ' ' },
                               StringSplitOptions.RemoveEmptyEntries);
            txtXuat.Text = "Có " + arr.Length + " từ";
        }

        private void btnDem_Click(object sender, RoutedEventArgs e)
        {
            int sokitu = txtNhap.Text
               .Count(c => char.IsUpper(c));
            txtXuat.Text = "Có " + sokitu + " kí tự in hoa ";
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
