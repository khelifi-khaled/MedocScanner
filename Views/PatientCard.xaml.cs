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
    /// Logique d'interaction pour patientCard.xaml
    /// </summary>
    public partial class PatientCard : Window
    {
        public PatientCardVM PatientCardVM { get; set; }


        public PatientCard(PatientCollection patients , string patientBarCode)
        {
            PatientCardVM = new PatientCardVM(patients,patientBarCode);
            DataContext=PatientCardVM;
            InitializeComponent();
        }



    }
}
