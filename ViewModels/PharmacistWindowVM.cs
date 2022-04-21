using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class PharmacistWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string PRESCRIPTION_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Prescriptions.json";


        public PharmacistWindowVM()
        {
            AccessjsonPrescriptions = new DataAccessJsn(PRESCRIPTION_JSON_FILE, new string[] { "json" });

            Prescriptions = AccessjsonPrescriptions.GetPrescriptionsDatas();
        }

        public PrescriptionCollection Prescriptions { get; set; }

        public DataAccessJsn AccessjsonPrescriptions { get; set; }


        public Prescription ThisPrescription { get; set; }




        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged


    }//end class 
}//end project 
