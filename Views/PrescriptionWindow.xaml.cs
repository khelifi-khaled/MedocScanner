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
    /// Logique d'interaction pour PrescriptionWindow.xaml
    /// </summary>
    public partial class PrescriptionWindow : Window
    {
        public PrescriptionWindowVM PrescriptionVM { get; set; }


        public PrescriptionWindow(Prescription thisPrescription, MedicineCollection medicines)
        {
            PrescriptionVM = new PrescriptionWindowVM(thisPrescription, medicines) ;
            DataContext=PrescriptionVM;
            InitializeComponent();
        }
    }
}
