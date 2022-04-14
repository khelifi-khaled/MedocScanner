using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public class PatientCollection : ObservableCollection<Patient>
    {


        public Patient GetPatien(string BarCode)
        {
            List<Patient> Patients = this.ToList<Patient>();

            return Patients.Find(p=>p.IdPatient.Equals(BarCode));
        }

    }//end class 
}//end project 
