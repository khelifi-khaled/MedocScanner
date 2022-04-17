using MedocScanner.Models;
using MedocScanner.ViewModels;
using MedocScanner.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedocScanner
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM MainVM { get; set; }


        public MainWindow()
        {
            MainVM = new MainWindowVM();
            DataContext = MainVM;
            InitializeComponent();
        }
        

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
            MainVM.AccessjsonPrescriptions.UpdateAllPrescriptionsDatas(MainVM.Prescriptions);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow Login = new LoginWindow(MainVM.Workers, MainVM.Patients, MainVM.Medicines, MainVM.Prescriptions);
            Login.Show();
            this.Close();
        }

        
    }//end class 
}//end project 
