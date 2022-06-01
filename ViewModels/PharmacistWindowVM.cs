using MedocScanner.Models;
using MedocScanner.Views;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public class PharmacistWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        public PharmacistWindowVM(PrescriptionCollection prescriptions, Pharmacist workerConnected)
        {
            Prescriptions=prescriptions;
            WorkerConnected=workerConnected;
        }

        public Pharmacist WorkerConnected { get; set; }

        public PrescriptionCollection Prescriptions { get; set; }
     

        public Prescription ThisPrescription { get; set; }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }//end OnPropertyChanged

        public void DataGrid_DoubleClick()
        {
            MedocPrescriptionWindow MedocWindow = new MedocPrescriptionWindow(ThisPrescription);
            MedocWindow.Show();
        }

        public void se_deconnecter(PharmacistWindow win)
        {
            WorkerConnected = null;
            MainWindow main = new MainWindow();
            main.Show();
            win.Close();
        }


    }//end class 
}//end project 
