using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class DoctorWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Worker _doctorConnected; 

        public DoctorWindowVM(Worker doctorConnected , PatientCollection patients, MedicineCollection medicines )
        {
            DoctorConnected=doctorConnected;
            Patients=patients;
            Medicines = medicines;
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

        public PatientCollection Patients { get; set; }

        public MedicineCollection Medicines { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }//end class 
}//end project 
