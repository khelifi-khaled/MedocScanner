using MedocScanner.Models;
using System.ComponentModel;

namespace MedocScanner.ViewModels
{
    public class PrescriptionWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private Prescription _thisPrescription;

        public PrescriptionWindowVM(Prescription thisPrescription, MedicineCollection medicines , PrescriptionCollection prescriptions)
        {
            ThisPrescription=thisPrescription;
            Medicines=medicines;
            Prescriptions = prescriptions;
        }





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


        public MedicineCollection Medicines { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
