using MedocScanner.Models;
using MedocScanner.Utilities;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private const string WORKERS_JSON_FILE = @"C:\Users\Admin\source\repos\MedocScanner\Workers.json";
        private const string CONN_STRING = @"Data Source=DESKTOP-LQ71Q13\KHALED ;Initial Catalog=MedocScannerDB ;integrated security = True;";

        public MainWindowVM()
        {
            
            //AccessjsonWorkers = new DataAccessJsn(WORKERS_JSON_FILE, new string[] { "json" });
            // Workers = AccessjsonWorkers.GetWorkersDatas();

            AccessSQLWorkers = new DataAccessSQL(CONN_STRING);
            Workers = AccessSQLWorkers.GetWorkersDatas();

        }

        public WorkerCollection Workers { get; set; }

        // public DataAccessJsn AccessjsonWorkers { get; set;}

        public DataAccessSQL AccessSQLWorkers { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
