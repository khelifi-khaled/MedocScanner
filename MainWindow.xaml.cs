using MedocScanner.Models;
using MedocScanner.ViewModels;
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

namespace MedocScanner
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM MainVM { get; set; }


        public MainWindow()
        {
            MainVM = new MainWindowVM();
            DataContext = MainVM;
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void TestCreatePatient_Click(object sender, RoutedEventArgs e)
        {
            Patient p1 = new Patient(DateTime.Now, DateTime.Now,"123456123","jon","hindrix", "mal au ventre coté droit",true,"7000 Mons");

            Patient p2 = new Patient(DateTime.Now, DateTime.Now, "326546549", "toto", "test", "mal au ventre coté gauche", true, "6000 charleroi");

            MainVM.Patients= new PatientCollection();
            MainVM.Patients.Add(p1);
            MainVM.Patients.Add(p2);

            MainVM.AccessjsonPatients.UpdateAllPatientsDatas(MainVM.Patients);

        }

        private void TestCreateMedicine_Click(object sender, RoutedEventArgs e)
        {

        }
    }//end class 
}//end project 
