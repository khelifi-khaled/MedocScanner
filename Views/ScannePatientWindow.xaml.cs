using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;
using System.Windows.Input;


namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour ScannePatientWindow.xaml
    /// </summary>
    public partial class ScannePatientWindow : Window
    {
        public ScannePatientWindowVM scannePatientVM { get; set; }

        public ScannePatientWindow(PatientCollection patients, MedicineCollection medicines, Prescription prescriptionForPatient, PrescriptionCollection prescriptions)
        {
            scannePatientVM=new ScannePatientWindowVM(patients, medicines, prescriptionForPatient, prescriptions);
            DataContext=scannePatientVM;
            InitializeComponent();
        }


        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void IdPatient_KeyDown(object sender, KeyEventArgs e)
        {
            scannePatientVM.Scanner(e, IdPatient.Text, this);
        }
    }
}
