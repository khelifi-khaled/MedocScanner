using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class DoctorWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Worker _doctorConnected;

        private const string MEDICINES_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\medicines.json";

        private const string PATIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Patients.json";

        private const string PRESCRIPTION_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Prescriptions.json";

        public DoctorWindowVM(Worker doctorConnected )
        {
            DoctorConnected=doctorConnected;
            AccessjsonPatients = new DataAccessJsn(PATIENTS_JSON_FILE, new string[] { "json" });
            AccessjsonMedicine = new DataAccessJsn(MEDICINES_JSON_FILE, new string[] { "json" });
            AccessjsonPrescriptions = new DataAccessJsn(PRESCRIPTION_JSON_FILE, new string[] { "json" });

            Medicines = AccessjsonMedicine.GetMedicinesDatas();
            Patients = AccessjsonPatients.GetPatientsDatas();
            Prescriptions = AccessjsonPrescriptions.GetPrescriptionsDatas();

        }


        public MedicineCollection Medicines { get; set; }

        public PatientCollection Patients { get; set; }

        public PrescriptionCollection Prescriptions { get; set; }

        public DataAccessJsn AccessjsonMedicine { get; set; }

        public DataAccessJsn AccessjsonPatients { get; set; }


        public DataAccessJsn AccessjsonPrescriptions { get; set; }


        public Worker DoctorConnected
        {
            get => _doctorConnected;
            set
            {
                _doctorConnected = value;
                OnPropertyChanged(nameof(DoctorConnected));
            }
        }



       public  Prescription PrescriptionForPatient { get; set; }

        public MedicineCollection PatientMedicines { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 
}//end project 
