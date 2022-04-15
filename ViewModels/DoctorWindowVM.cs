using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class DoctorWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Worker _doctorConnected; 

        public DoctorWindowVM(Worker doctorConnected , PatientCollection patients, MedicineCollection medicines, PrescriptionCollection pescriptions)
        {
            DoctorConnected=doctorConnected;
            Patients=patients;
            Medicines = medicines;
            Pescriptions = pescriptions;
        }

        public Worker DoctorConnected
        {
            get => _doctorConnected;
            set
            {
                _doctorConnected = value;
                OnPropertyChanged(nameof(DoctorConnected));
            }
        }



        public PrescriptionCollection Pescriptions { get; set; }


        public PatientCollection Patients { get; set; }

        public MedicineCollection Medicines { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 
}//end project 
