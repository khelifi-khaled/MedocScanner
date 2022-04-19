using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private const string WORKERS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Workers.json";

        public MainWindowVM()
        {
            AccessjsonWorkers = new DataAccessJsn(WORKERS_JSON_FILE, new string[] { "json" });
            Workers = AccessjsonWorkers.GetWorkersDatas();
        }

        public WorkerCollection Workers { get; set; }

        public DataAccessJsn AccessjsonWorkers { get; set; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
