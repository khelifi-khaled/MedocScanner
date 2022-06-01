using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;

namespace MedocScanner.Views
{
    
    public partial class PharmacistWindow : Window
    {
        public PharmacistWindowVM PharmacistVM { get; set; }


        public PharmacistWindow(PrescriptionCollection prescreption , Pharmacist workerConnected)
        {
            PharmacistVM = new PharmacistWindowVM(prescreption, workerConnected);
            DataContext = PharmacistVM;
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PharmacistVM.DataGrid_DoubleClick();
        }

        private void se_deconnecter_Click(object sender, RoutedEventArgs e)
        {
            PharmacistVM.se_deconnecter(this);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
