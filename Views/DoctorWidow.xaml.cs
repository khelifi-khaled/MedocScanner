using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour DoctorWidow.xaml
    /// </summary>
    public partial class DoctorWidow : Window
    {
        public DoctorWindowVM DoctorVM { get; set; }

        public DoctorWidow(Doctor doctorConnected, PrescriptionCollection prescriptions)
        {
            DoctorVM = new DoctorWindowVM(doctorConnected, prescriptions);
            DataContext = DoctorVM;
            InitializeComponent();
        }

        private void se_deconnecter_Click(object sender, RoutedEventArgs e)
        {
            DoctorVM.se_deconnecter(this);
        }

        private void ButtonNew_prescription_Click(object sender, RoutedEventArgs e)
        {
            DoctorVM.CreateNewPrescription();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
            DoctorVM.SauvgardPrescription();
        }



    }//end class 
}//end project 
