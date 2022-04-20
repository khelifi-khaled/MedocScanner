using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
   
    public partial class MedocWindow : Window
    {

        public MedocWindowVM MedocWindowVM { get; set; }



        public MedocWindow(Prescription prescription, MedicineCollection medicines)
        {
            MedocWindowVM = new MedocWindowVM(prescription, medicines);
            DataContext = MedocWindowVM;
            InitializeComponent();
        }

        private void TxtIdMedicin_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            MedocWindowVM.MedicineSelected = MedocWindowVM.Medicines.GetMedicine(TxtIdMedicin.Text);

        }

        private void AddMedoc_Click(object sender, RoutedEventArgs e)
        {
            MedocWindowVM.AddMedoc(this);
        }

        private void CancelAddMedoc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
