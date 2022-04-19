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

        private void TxtIdPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                scannePatientVM.PatientSelected = scannePatientVM.Patients.GetPatien(TxtIdPatient.Text);

                if (scannePatientVM.PatientSelected!=null)
                {
                    //sending the patient selected to our prescription 
                    scannePatientVM.PrescriptionForPatient.Patient = scannePatientVM.PatientSelected;

                    PrescriptionWindow NewPrescriptionWindow = new PrescriptionWindow(scannePatientVM.PrescriptionForPatient, scannePatientVM.Medicines, scannePatientVM.Prescriptions);
                    NewPrescriptionWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"cher docteur {scannePatientVM.PrescriptionForPatient.Doctor.FullName} ce patient n'existe pas dans le fichier json ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
