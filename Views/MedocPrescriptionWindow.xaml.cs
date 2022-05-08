
using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    
    public partial class MedocPrescriptionWindow : Window
    {
        public MadocPrescriptionWindowVM MedocPrescriptionVM { get; set; }

        public MedocPrescriptionWindow(Prescription prescription )
        {
            MedocPrescriptionVM = new MadocPrescriptionWindowVM(prescription);
            DataContext = MedocPrescriptionVM;
            InitializeComponent();
        }

        private void DoctorInfos_Click(object sender, RoutedEventArgs e)
        {
            DoctorInfosWindow DoctorInfos = new DoctorInfosWindow(MedocPrescriptionVM.Prescription.Doctor);
            DoctorInfos.Show();
        }

        private void PatientInfos_Click(object sender, RoutedEventArgs e)
        {
            PatientInfosWindow patientInfos = new PatientInfosWindow(MedocPrescriptionVM.Prescription.Patient);
            patientInfos.Show();
        }
    }
}
