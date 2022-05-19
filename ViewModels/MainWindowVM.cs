using MedocScanner.Models;
using MedocScanner.Utilities;
using MedocScanner.Views;
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

            AccessSQL = new DataAccessSQL(CONN_STRING);
            Workers = AccessSQL.GetWorkersDatas();
            Prescriptions= AccessSQL.GetPrescriptionsDatas();
        }


        public PrescriptionCollection Prescriptions { get; set; }


        public WorkerCollection Workers { get; set; }

        // public DataAccessJsn AccessjsonWorkers { get; set;}

        public DataAccessSQL AccessSQL { get; set; }


        public void Login(MainWindow main)
        {
            LoginWindow Login = new LoginWindow(Workers, Prescriptions);
            Login.Show();
            main.Close();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

    }//end class 
}//end project 
