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




        public Worker WorkerSelected
        {
            get;set;
        }




        public string  WorkerTypeStected
        {
            get;set;
        }

        public void Login(string password , LoginWindow win)
        {
            WorkerSelected = Workers.GetWorkerSelected(WorkerTypeStected);

            if (WorkerSelected != null)//checking if the worker choosed his profession or not 
            {
                if (!string.IsNullOrEmpty(password))//checking if the worker Enter his password or not 
                {
                    if (WorkerSelected.GetType() == typeof(Doctor))//checking the worker type 
                    {
                        WorkerSelected = Workers.GetWorkerConected(password);

                        if (WorkerSelected != null)//if worker is not null sow the password is correct  
                        {
                            if (WorkerSelected.GetType()==typeof(Doctor))
                            {
                                DoctorWidow doctor = new DoctorWidow((Doctor)WorkerSelected, Prescriptions);
                                doctor.Show();
                                win.Close();
                            }else
                            {
                                MessageBox.Show($"Mr. {WorkerSelected.FullName} vous êtes Pharmacien, vous n'avais malheureusement pas l'axe a la page de Médecin ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("votre mot de passe est incorecte ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                            
                        }
                    }else
                    {
                        WorkerSelected= Workers.GetWorkerConected(password);

                        if (WorkerSelected != null)//if worker is not null sow the password is correct  
                        {
                            PharmacistWindow pharmacis = new PharmacistWindow(Prescriptions);
                            pharmacis.Show();
                            win.Close();
                        }
                        else
                        {
                            MessageBox.Show("votre mot de passe est incorecte ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("vous devez ecrire votre mot de passe ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("vous devez choisir votre professional ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end project 
