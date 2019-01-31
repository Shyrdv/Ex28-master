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

namespace DatabaseUI
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

        private void Insertpetbutton_Click(object sender, RoutedEventArgs e)
        {
            InsertPetWindow insertPetObject = new InsertPetWindow();
            insertPetObject.Show();
            this.Close();
        }

        private void Insertownerbutton_Click(object sender, RoutedEventArgs e)
        {
            InsertOwnerWindow insertOwnerObject = new InsertOwnerWindow();
            insertOwnerObject.Show();
            this.Close();
        }

        private void Showallpetsbutton_Click(object sender, RoutedEventArgs e)
        {
            ShowAllPetsWindow showAllPetsObject = new ShowAllPetsWindow();
            showAllPetsObject.Show();
            this.Close();
        }

        private void Findownerbylastnamebutton_Click(object sender, RoutedEventArgs e)
        {
            FindOwnerByLastNameWindow findOwnerByLastNameObject = new FindOwnerByLastNameWindow();
            findOwnerByLastNameObject.Show();
            this.Close();
        }
    }
}
