using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public  class LoginWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private string[] _listTypeWorker = { "Doctor", "Pharmacist"};

        public LoginWindowVM(WorkerCollection workers)
        {
            Workers = workers;

        }



        public string[] ListTypeWorker
        {
            get => _listTypeWorker; 
            set
            {
                _listTypeWorker = value;
                OnPropertyChanged(nameof(ListTypeWorker));
            }
        }





        public WorkerCollection Workers { get; set; }




        public Worker WorkerSelected
        {
            get;set;
        }




        public string  WorkerTypeStected
        {
            get;set;
        }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end project 
