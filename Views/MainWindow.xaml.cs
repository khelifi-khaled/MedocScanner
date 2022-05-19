using MedocScanner.Models;
using MedocScanner.Utilities;
using MedocScanner.ViewModels;
using MedocScanner.Views;
using System.Windows;

namespace MedocScanner.Views
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


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainVM.Login(this);
        }

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }//end class 
}//end project 
