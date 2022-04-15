using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        private const string MEDICINES_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\medicines.json";

        private const string PATIENTS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Patients.json";

        private const string WORKERS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Workers.json";

        private const string PRESCRIPTION_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Prescriptions.json";


        public MainWindowVM()
        {
           
            AccessjsonMedicine = new DataAccessJsn(MEDICINES_JSON_FILE, new string[] { "json" });
            AccessjsonPatients = new DataAccessJsn(PATIENTS_JSON_FILE, new string[] { "json" });
            AccessjsonWorkers = new DataAccessJsn(WORKERS_JSON_FILE, new string[] { "json" });
            AccessjsonPrescriptions = new DataAccessJsn(PRESCRIPTION_JSON_FILE, new string[] { "json" });

            Medicines = AccessjsonMedicine.GetMedicinesDatas();
            Patients = AccessjsonPatients.GetPatientsDatas();
            Workers = AccessjsonWorkers.GetWorkersDatas();
            Prescriptions= AccessjsonPrescriptions.GetPrescriptionsDatas();
        }

            
        

        public MedicineCollection Medicines { get ; set; }

        public PatientCollection Patients { get ; set; }

        public WorkerCollection Workers { get ; set; }


        public PrescriptionCollection Prescriptions { get; set; }







        public DataAccessJsn AccessjsonMedicine { get; set; }

        public DataAccessJsn AccessjsonPatients { get; set; }

        public DataAccessJsn AccessjsonWorkers { get; set; }


        public DataAccessJsn AccessjsonPrescriptions { get; set; }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
