using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    



    public partial class LoginWindow : Window
    {

        LoginWindowVM LoginVM { get; set; }



        public LoginWindow(WorkerCollection workers,PrescriptionCollection prescriptions)
        {
            LoginVM=new LoginWindowVM(workers,prescriptions); 
            DataContext=LoginVM;
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            LoginVM.Login(password.Password,this);
        }
    }
}
