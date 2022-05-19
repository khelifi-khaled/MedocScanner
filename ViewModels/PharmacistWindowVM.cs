using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class PharmacistWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string PRESCRIPTION_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Prescriptions.json";


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
