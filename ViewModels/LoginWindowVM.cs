using MedocScanner.Models;
using MedocScanner.Views;
using System.ComponentModel;
using System.Windows;

namespace MedocScanner.ViewModels
{
    public  class LoginWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private string[] _listTypeWorker = { "Médecin", "Pharmacien" };

        public LoginWindowVM(WorkerCollection workers, PrescriptionCollection prescriptions)
        {
            Workers = workers;
            Prescriptions= prescriptions;
        }

        public PrescriptionCollection Prescriptions { get; set; }

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




        public Worker WorkerConnected
        {
            get;set;
        }




        public string  WorkerTypeStected
        {
            get;set;
        }

        public void Login(string password , LoginWindow win)
        {
            WorkerConnected = Workers.GetWorkerSelected(WorkerTypeStected);

            if (WorkerConnected != null)//checking if the worker choosed his profession or not 
            {
                if (!string.IsNullOrEmpty(password))//checking if the worker Enter his password or not 
                {
                    if (WorkerConnected.GetType() == typeof(Doctor))//checking the worker type 
                    {
                        WorkerConnected = Workers.GetWorkerConected(password);

                        if (WorkerConnected != null)//if worker is not null sow the password is correct  
                        {
                            if (WorkerConnected.GetType()==typeof(Doctor))
                            {
                                DoctorWidow doctor = new DoctorWidow((Doctor)WorkerConnected, Prescriptions);
                                doctor.Show();
                                win.Close();
                            }else
                            {
                                MessageBox.Show($"Mr. {WorkerConnected.FullName} Vous êtes pharmacien, vous n'avez malheureusement pas l'accès à la page des médecins.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Votre mot de passe est incorrect.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                            
                        }
                    }else
                    {
                        WorkerConnected = Workers.GetWorkerConected(password);

                        if (WorkerConnected != null)//if worker is not null sow the password is correct  
                        {
                            if (WorkerConnected.GetType() == typeof(Pharmacist))
                            {
                                PharmacistWindow pharmacis = new PharmacistWindow(Prescriptions,(Pharmacist)WorkerConnected);
                                pharmacis.Show();
                                win.Close();
                            }else
                            {
                                MessageBox.Show($"Dr. {WorkerConnected.FullName} Vous êtes médecin, vous n'avez malheureusement pas l'accès à la page des pharmaciens.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Votre mot de passe est incorrect.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez indiquer votre mot de passe.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vous devez choisir votre profession.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end project 
