using MedocScanner.Models;
using MedocScanner.Views;
using System.ComponentModel;
using System.Windows;

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




        public void SavePrescription(PrescriptionWindow window)
        {
            if (ThisPrescription.Medicines.Count!=0)
            {
                Prescriptions.Add(ThisPrescription);
                window.Close();
            }
            else
            {
                MessageBox.Show($"pas de changement détecter, vous devez ajouter des médocs pour le patient ou annuler la creation de cette prescription ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
