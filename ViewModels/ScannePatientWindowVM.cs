using MedocScanner.Models;
using MedocScanner.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MedocScanner.ViewModels
{
    public  class ScannePatientWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public ScannePatientWindowVM(PatientCollection patients,MedicineCollection medicines,Prescription prescriptionForPatient,PrescriptionCollection prescriptions)
        {
            Patients=patients;
            Medicines=medicines;
            PrescriptionForPatient = prescriptionForPatient;
            Prescriptions = prescriptions;
        }

        public Patient PatientSelected { get; set; }

        public PatientCollection Patients { get; set; }

        public MedicineCollection Medicines { get; set; }

        public Prescription PrescriptionForPatient { get; set; }

        public PrescriptionCollection Prescriptions { get; set; }


        public void Scanner(KeyEventArgs e,string idPatient , ScannePatientWindow win)
        {
            if (e.Key == Key.Enter)
            {
                PatientSelected = Patients.GetPatien(idPatient);

                if (PatientSelected != null)
                {
                    //sending the patient selected to our prescription 
                    PrescriptionForPatient.Patient = PatientSelected;

                    PrescriptionWindow NewPrescriptionWindow = new PrescriptionWindow(PrescriptionForPatient, Medicines, Prescriptions);
                    NewPrescriptionWindow.Show();
                    win.Close();
                }
                else
                {
                    MessageBox.Show($"cher docteur {PrescriptionForPatient.Doctor.FullName} ce patient n'existe pas dans le fichier json ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged



    }//end class 
}//end pkroject 
