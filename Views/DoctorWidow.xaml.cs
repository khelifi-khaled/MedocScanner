
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

        public DoctorWidow(Worker doctorConnected,PatientCollection patients,MedicineCollection medicines, PrescriptionCollection pescriptions)
        {
            DoctorVM = new DoctorWindowVM(doctorConnected, patients, medicines, pescriptions);
            DataContext = DoctorVM;
            InitializeComponent();
        }

       

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        private void se_deconnecter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();           
        }

        private void ButtonNew_prescription_Click(object sender, RoutedEventArgs e)
        {
            ScannePatientWindow ScannePatient = new ScannePatientWindow(DoctorVM.DoctorConnected, DoctorVM.Patients, DoctorVM.Medicines , DoctorVM.Pescriptions);
            ScannePatient.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
