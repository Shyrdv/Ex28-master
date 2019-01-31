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
    /// Interaction logic for InsertPetWindow.xaml
    /// </summary>
    public partial class InsertPetWindow : Window
    {
        public InsertPetWindow()
        {
            InitializeComponent();
        }

        private void ReturnToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void AddPetButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseController db = new DatabaseController();

            db.InsertRow(petNameBox.Text, petTypeBox.Text, petBreedBox.Text, petDOBDatePicker.Text, petWeightBox.Text);
        }

        private void PetNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            petNameBox.Foreground = Brushes.Black;
        }

        private void PetNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            petNameBox.Clear();
        }

        private void PetNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
