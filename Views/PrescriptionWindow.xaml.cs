using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;

namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour PrescriptionWindow.xaml
    /// </summary>
    public partial class PrescriptionWindow : Window
    {
        public PrescriptionWindowVM PrescriptionVM { get; set; }


        public PrescriptionWindow(Prescription thisPrescription, MedicineCollection medicines, PrescriptionCollection prescriptions)
        {
            PrescriptionVM = new PrescriptionWindowVM(thisPrescription, medicines, prescriptions) ;
            DataContext=PrescriptionVM;
            InitializeComponent();
        }

       

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            PrescriptionVM.SavePrescription(this);
        }

        

        private void NouveauMedoc_Click(object sender, RoutedEventArgs e)
        {
            MedocWindow medocWindow = new MedocWindow(PrescriptionVM.ThisPrescription, PrescriptionVM.Medicines);
            medocWindow.Show();   
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
