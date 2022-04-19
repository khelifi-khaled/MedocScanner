using MedocScanner.Models;
using System.ComponentModel;

namespace MedocScanner.ViewModels
{
    public  class MedocWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Medicine _medicineSelected;



        public MedocWindowVM (Prescription prescription , MedicineCollection medicines)
        {
            Prescription=prescription;
            Medicines=medicines;
        }

        public Prescription Prescription { get; set; }

        public MedicineCollection Medicines { get; set; }

        public Medicine MedicineSelected
        {
            get => _medicineSelected;
            set
            {
                _medicineSelected=value;
                OnPropertyChanged(nameof(MedicineSelected));
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
