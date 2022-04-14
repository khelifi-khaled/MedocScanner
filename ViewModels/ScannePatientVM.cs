using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.ViewModels
{
    public class ScannePatientVM
    {
        public ScannePatientVM(PatientCollection patients)
        {
            Patients=patients;
        }


        public PatientCollection Patients { get; set; }

        public string PatientBarCode { get; set; }

    }//end class 
}//end project 
