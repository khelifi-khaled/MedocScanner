using MedocScanner.Models;
using MedocScanner.Views;
using System.ComponentModel;
using System.Windows;

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


        public void AddMedoc(MedocWindow win)
        {
            if (MedicineSelected != null)
            {
                Prescription.Medicines.AddMedicine(MedicineSelected);
                win.Close();
            }
            else
            {
                MessageBox.Show("Le médicament sélectionné est introuvable.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
