using MedocScanner.Models;
using MedocScanner.ViewModels;
using System;
using System.Windows;


namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour DoctorWidow.xaml
    /// </summary>
    public partial class DoctorWidow : Window
    {
        public DoctorWindowVM DoctorVM { get; set; }

        public DoctorWidow(Worker doctorConnected)
        {
            DoctorVM = new DoctorWindowVM(doctorConnected);
            DataContext = DoctorVM;
            InitializeComponent();
        }

       

       
       

        private void se_deconnecter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();           
        }

        private void ButtonNew_prescription_Click(object sender, RoutedEventArgs e)
        {

            //Empty Medicine Collection  for our patient 
            DoctorVM.PatientMedicines = new MedicineCollection();

            //Prescription with(Today date + PrescriptionId +  our patient = null  + the doctor connected + Empty Medicine Collection of our patient)
            DoctorVM.PrescriptionForPatient = new Prescription(DateTime.Now, DoctorVM.Prescriptions.GetPrescriptionId(),null, DoctorVM.DoctorConnected,DoctorVM.PatientMedicines);

            ScannePatientWindow ScannePatient = new ScannePatientWindow(DoctorVM.Patients, DoctorVM.Medicines , DoctorVM.PrescriptionForPatient,DoctorVM.Prescriptions);
            ScannePatient.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
            DoctorVM.AccessjsonPrescriptions.UpdateAllPrescriptionsDatas(DoctorVM.Prescriptions);
            MessageBox.Show("Tous les prescriptions ont bien été enregistrée dans le fichier JSON ", "Message", MessageBoxButton.OK);
        }
    }
}
