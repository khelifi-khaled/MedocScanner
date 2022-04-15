using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.ViewModels
{
    public  class ScannePatientWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public ScannePatientWindowVM(Worker doctorConnected, PatientCollection patients, MedicineCollection medicines,PrescriptionCollection prescriptions)
        {
            DoctorConnected=doctorConnected;
            Patients=patients;
            Medicines = medicines;
            Prescriptions= prescriptions;
        }

        public PrescriptionCollection Prescriptions { get; set; }

        public Prescription PrescriptionForPatient { get; set; }

        public Patient PatientSelected { get; set; }

        public Worker DoctorConnected { get; set; }

        public PatientCollection Patients { get; set; }

        public MedicineCollection Medicines { get; set; }

        public MedicineCollection PatientMedicines { get; set; }





        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged



    }//end class 
}//end pkroject 
