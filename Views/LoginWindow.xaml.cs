using MedocScanner.ViewModels;
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
using System.Windows.Shapes;

namespace MedocScanner.Views
{
    



    public partial class LoginWindow : Window
    {

        LoginWindowVM LoginVM { get; set; }



        public LoginWindow()
        {
            LoginVM=new LoginWindowVM(); 
            DataContext=LoginVM;
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
