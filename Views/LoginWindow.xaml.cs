using MedocScanner.Models;
using MedocScanner.ViewModels;
using System.Windows;


namespace MedocScanner.Views
{
    



    public partial class LoginWindow : Window
    {

        LoginWindowVM LoginVM { get; set; }



        public LoginWindow(WorkerCollection workers)
        {
            LoginVM=new LoginWindowVM(workers); 
            DataContext=LoginVM;
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {
            LoginVM.Login(password.Text,this);
        }
    }
}
