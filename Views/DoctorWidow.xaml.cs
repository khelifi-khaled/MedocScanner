
using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour DoctorWidow.xaml
    /// </summary>
    public partial class DoctorWidow : Window
    {
        public DoctorWindowVM DoctorVM { get; set; }

        public DoctorWidow(Worker doctorConnected, PatientCollection patients, MedicineCollection medicines)
        {
            DoctorVM = new DoctorWindowVM(doctorConnected, patients, medicines);
            DataContext = DoctorVM;
            InitializeComponent();
        }

       

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void se_deconnecter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonNew_prescription_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
