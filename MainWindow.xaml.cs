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

        private void TestCreatePatient_Click(object sender, RoutedEventArgs e)
        {
            Patient p1 = new Patient( DateTime.Now,"123456123","jon","hindrix", "mal au ventre coté droit",true,"7000 Mons");

            Patient p2 = new Patient(DateTime.Now, "326546549", "toto", "test", "mal au ventre coté gauche", true, "6000 charleroi");

            MainVM.Patients= new PatientCollection();
            MainVM.Patients.Add(p1);
            MainVM.Patients.Add(p2);

            MainVM.AccessjsonPatients.UpdateAllPatientsDatas(MainVM.Patients);

        }

        private void TestCreateMedicine_Click(object sender, RoutedEventArgs e)
        {
            Medicine m1 = new Medicine("1231231321", "Metagenics MetaRelax 180 Comprimés",12.99);

            Medicine m2 = new Medicine("3216549875", "perfusion algodystrophie 200 ml", 10.26);

            MainVM.Medicines = new MedicineCollection();
            MainVM.Medicines.Add(m1);
            MainVM.Medicines.Add(m2);

            MainVM.AccessjsonMedicine.UpdateAllMedicinesDatas(MainVM.Medicines);




           
        }

        private void TestCreateDoctor_Click(object sender, RoutedEventArgs e)
        {

            Doctor m1 = new Doctor("Test1234","Antoine","okendi", "Antoine@gmail.com","0467833154","Pv 2 - salle 345","1000 Bruxelles") ;
            Doctor m2 = new Doctor("Test1234567", "zaki", "imponza", "imponza@yahoo.com", "0467835684", "Pv 1 - salle 854", "1040 Etterbeek");
            MainVM.Workers = new WorkerCollection();
            MainVM.Workers.Add(m1);
            MainVM.Workers.Add(m2);     

            Pharmacist p1 = new Pharmacist("toto123", "jon", "kaka", "jon@gmail.com", "0456789523", "Pv 6 - salle 2-1", "1000 Bruxelles");
            Pharmacist p2 = new Pharmacist("toto123123123", "noel", "Cotton", "noel@Hotmail.com", "0400000003", "Pv 3 - salle 225", "1040 Etterbeek");
            MainVM.Workers.Add(p1);
            MainVM.Workers.Add(p2);
            MainVM.AccessjsonWorkers.UpdateAllWorkersDatas(MainVM.Workers);
        }

        private void TestPatientcodebare_Click(object sender, RoutedEventArgs e)
        {
            



        }

        private void Sauver_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow Login = new LoginWindow(MainVM.Workers, MainVM.Patients, MainVM.Medicines, MainVM.Prescriptions);
            Login.Show();
        }

        
    }//end class 
}//end project 
