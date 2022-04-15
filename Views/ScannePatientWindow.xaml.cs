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
using System.Windows.Shapes;

namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour ScannePatientWindow.xaml
    /// </summary>
    public partial class ScannePatientWindow : Window
    {
        ScannePatientWindowVM scannePatientVM { get; set; }

        public ScannePatientWindow(Worker doctorConnected, PatientCollection patients, MedicineCollection medicines,PrescriptionCollection prescriptions)
        {
            scannePatientVM=new ScannePatientWindowVM(doctorConnected, patients, medicines, prescriptions);
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
                    //Empty Medicine Collection  for our patient 
                    scannePatientVM.PatientMedicines = new MedicineCollection();

                    //Prescription with(Today date + PrescriptionId +  our patient + the doctor connected + Empty Medicine Collection of our patient)
                    scannePatientVM.PrescriptionForPatient = new Prescription(DateTime.Now, scannePatientVM.Prescriptions.GetPrescriptionId(), scannePatientVM.PatientSelected, scannePatientVM.DoctorConnected, scannePatientVM.PatientMedicines);

                    //Making the new prescription in out main Prescription collection    
                    scannePatientVM.Prescriptions.Add(scannePatientVM.PrescriptionForPatient);

                    PrescriptionWindow NewPrescriptionWindow = new PrescriptionWindow(scannePatientVM.PrescriptionForPatient, scannePatientVM.Medicines);
                    NewPrescriptionWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"cher docteur {scannePatientVM.DoctorConnected.FullName}ce patient n'existe pas dans le fichier", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
