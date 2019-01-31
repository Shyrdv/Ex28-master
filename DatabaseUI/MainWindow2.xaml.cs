using Service;
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
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window, IObserver
    {
        PetRepo petrepo = new PetRepo();

        public MainWindow2()
        {
            InitializeComponent();
            petrepo.RegisterObserver(this);
        }

        public void Update(ISubject subject, string message)
        {
            listView.Items.Clear();
            foreach (var pet in (subject as PetRepo).GetAll())
           {
                listView.Items.Add(pet);
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            petrepo.AddPet("Hej ", "Med ", "Dig ", "19-02-19 ", "300 ", 1);

        }
    }
}
