
using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;




namespace MedocScanner.Views
{
   
    public partial class PatientInfosWindow : Window
    {
        public PatienInfosWindowVM PatienInfosVM { get; set; } 


        public PatientInfosWindow(Patient patient)
        {
            PatienInfosVM = new PatienInfosWindowVM(patient);
            DataContext = PatienInfosVM;
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
