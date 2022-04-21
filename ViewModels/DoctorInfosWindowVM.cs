using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class DoctorInfosWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DoctorInfosWindowVM(Worker doctor)
        {
            ThisDoctor = doctor;
        }

        public Worker ThisDoctor { get; set; }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }//end class 
}//end project 
