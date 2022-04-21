using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class PatienInfosWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public PatienInfosWindowVM (Patient patient)
        {
            ThisPatient=patient;
        }


        public Patient ThisPatient { get; set; }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged



    }//end class 
}//end project 
