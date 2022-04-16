using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.ViewModels
{
    public class PrescriptionWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Prescription _thisPrescription;

        public PrescriptionWindowVM(Prescription thisPrescription, MedicineCollection medicines)
        {
            ThisPrescription=thisPrescription;
            Medicines=medicines;
        }



        public MedicineCollection Medicines { get; set; }


        public Prescription ThisPrescription 
        {
            get => _thisPrescription;
            set
            {
                _thisPrescription = value;
                OnPropertyChanged(nameof(ThisPrescription));
            }
        }

        public PrescriptionCollection Prescriptions { get; set; }

        public Patient PatientSelected { get; set; }

        public Worker DoctorConnected { get; set; }

        public PatientCollection Patients { get; set; }

        public MedicineCollection PatientMedicines { get; set; }




        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
