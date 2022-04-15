using MedocScanner.Models;
using MedocScanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MedocScanner.Views
{
    



    public partial class LoginWindow : Window
    {

        LoginWindowVM LoginVM { get; set; }



        public LoginWindow(WorkerCollection workers, PatientCollection patients, MedicineCollection medicines, PrescriptionCollection prescriptions)
        {
            LoginVM=new LoginWindowVM(workers, patients, medicines, prescriptions); 
            DataContext=LoginVM;
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            LoginVM.WorkerSelected = LoginVM.Workers.GetWorkerSelected(LoginVM.WorkerTypeStected);

            if (LoginVM.WorkerSelected!=null)//checking if the worker choosed his profession or not 
            {
               if (!string.IsNullOrEmpty(password.Text))//checking if the worker Enter his password or not 
                {
                    if (LoginVM.WorkerSelected.GetType() == typeof(Doctor))//checking the worker type 
                    {
                        LoginVM.WorkerSelected = LoginVM.Workers.GetWorkerConected(password.Text);

                        if (LoginVM.WorkerSelected!=null)//if worker is not null sow the password is correct  
                        {
                            DoctorWidow doctor = new DoctorWidow(LoginVM.WorkerSelected,LoginVM.Patients,LoginVM.Medicines,LoginVM.Prescriptions);
                            doctor.Show();
                            this.Close();
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
    }
}
