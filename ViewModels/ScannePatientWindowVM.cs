using MedocScanner.Models;
using System.ComponentModel;

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





        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged



    }//end class 
}//end pkroject 
