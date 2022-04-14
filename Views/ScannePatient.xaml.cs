using MedocScanner.Models;
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
    /// <summary>
    /// Logique d'interaction pour ScannePatient.xaml
    /// </summary>
    public partial class ScannePatient : Window
    {
        public ScannePatientVM ScanneVM { get; set; }


        public ScannePatient(PatientCollection patients)
        {
            ScanneVM = new ScannePatientVM(patients);
            DataContext = ScanneVM;
            InitializeComponent();
        }

     

       

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key ==Key.Enter)
            {
                PatientCard p = new PatientCard(ScanneVM.Patients, txtBarCode.Text);
                p.Show();
                this.Close();
            }
            
        }
    }
}
