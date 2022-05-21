using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class PharmacistWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        public PharmacistWindowVM(PrescriptionCollection prescriptions)
        {
            Prescriptions=prescriptions;
        }

        public PrescriptionCollection Prescriptions { get; set; }
     

        public Prescription ThisPrescription { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged


    }//end class 
}//end project 
