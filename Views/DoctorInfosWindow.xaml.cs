using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    /// <summary>
    /// Logique d'interaction pour DoctorInfosWindow.xaml
    /// </summary>
    public partial class DoctorInfosWindow : Window
    {
        public DoctorInfosWindowVM DoctorInfoVM { get; set; }

        public DoctorInfosWindow(Worker doctor)
        {
            DoctorInfoVM = new DoctorInfosWindowVM(doctor);
            DataContext = DoctorInfoVM;
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
