using MedocScanner.ViewModels;
using System.Windows;

namespace MedocScanner.Views
{
    
    public partial class PharmacistWindow : Window
    {
        public PharmacistWindowVM PharmacistVM { get; set; }


        public PharmacistWindow()
        {
            PharmacistVM = new PharmacistWindowVM();
            DataContext = PharmacistVM;
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MedocPrescriptionWindow MedocPrescriptionWindow = new MedocPrescriptionWindow(PharmacistVM.ThisPrescription);
            MedocPrescriptionWindow.Show();
        }
    }
}
