using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.ViewModels
{
    public class PatientCardVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Patient _patientSelected;


        public  PatientCardVM (PatientCollection patients , string patientBarCode )
        {
            Patients = patients;
            PatientSelected = Patients.GetPatien(patientBarCode);
        }

        public PatientCollection Patients { get; set; }




        public Patient PatientSelected
        { 
            get
            {
                return _patientSelected;
            }
            set
            {
                _patientSelected = value;
                OnPropertyChanged(nameof(PatientSelected));
            }
        }




        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged
    }//end class 
}//end project 
