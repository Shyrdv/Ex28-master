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
using ApplicationLayer;

namespace DatabaseUI
{
    /// <summary>
    /// Interaction logic for ShowAllPetsWindow.xaml
    /// </summary>
    public partial class ShowAllPetsWindow : Window
    {
        public ShowAllPetsWindow()
        {
            
            DatabaseController db = new DatabaseController();
            InitializeComponent();
            db.ShowPets();
            petnameBox.Text += db.s1;
            petnameBox_Copy.Text += db.s2;
            petnameBox_Copy1.Text += db.s3;
            petnameBox_Copy2.Text += db.s4;
            petnameBox_Copy3.Text += db.s5;
            petnameBox_Copy4.Text += db.s6;
            petnameBox_Copy5.Text += db.s7;
        }

        private void ReturnToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
