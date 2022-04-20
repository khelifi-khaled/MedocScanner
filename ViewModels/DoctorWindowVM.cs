using MedocScanner.Models;
using MedocScanner.Utilities;
using MedocScanner.Views;
using System;
using System.ComponentModel;
using System.Windows;

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


        public void CreateNewPrescription()
        {
            //Medicine Collection for our patient 
            PatientMedicines = new MedicineCollection();
            //Prescription For our Patient with Now DateTime + id + the pateint is null + Doctor Connected
            PrescriptionForPatient = new Prescription(DateTime.Now, Prescriptions.GetPrescriptionId(),null, DoctorConnected, PatientMedicines);

            ScannePatientWindow ScannePatient = new ScannePatientWindow(Patients, Medicines, PrescriptionForPatient, Prescriptions);
            ScannePatient.Show();

        }//end CreateNewPrescription



        public void SauvgardPrescription()
        {
            AccessjsonPrescriptions.UpdateAllPrescriptionsDatas(Prescriptions);
            MessageBox.Show("Tous les prescriptions ont bien été enregistrée dans le fichier JSON ", "Message", MessageBoxButton.OK);
        }//end SauvgardPrescription

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 
}//end project 
