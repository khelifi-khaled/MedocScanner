using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private const string DOCTORS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Doctors.json";

        private const string MEDICINES_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\medicines.json";

        private const string PATIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Patients.json";

        private const string PHARMACISTS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Pharmacists.json";


        public MainWindowVM()
        {
            AccessjsonDoctors = new DataAccessJsn(DOCTORS_JSON_FILE, new string[] { "json" });
            AccessjsonMedicine = new DataAccessJsn(MEDICINES_JSON_FILE, new string[] { "json" });
            AccessjsonPatients = new DataAccessJsn(PATIENTS_JSON_FILE, new string[] { "json" });
            AccessjsonPharmacists = new DataAccessJsn(PHARMACISTS_JSON_FILE, new string[] { "json" });

            Doctors = AccessjsonDoctors.GetDoctorsDatas();
            Medicines = AccessjsonMedicine.GetMedicinesDatas();
            Patients = AccessjsonPatients.GetPatientsDatas();
            Pharmacists = AccessjsonPharmacists.GetPharmacistsDatas();
        }

            
        public DoctorCollection Doctors { get ; set; }

        public MedicineCollection Medicines { get ; set; }

        public PatientCollection Patients { get ; set; }

        public PharmacistCollection Pharmacists { get ; set; }





        public DataAccessJsn AccessjsonDoctors { get; set; }

        public DataAccessJsn AccessjsonMedicine { get; set; }

        public DataAccessJsn AccessjsonPatients { get; set; }

        public DataAccessJsn AccessjsonPharmacists { get; set; }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
