using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public class PatientCollection : ObservableCollection<Patient>
    {

        /// <summary>
        /// Get the Patien that we are looking for, from this list, throw the Patien BarCode  
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns> Patien thant we are looking for</returns>
        public Patient GetPatien(string BarCode)
        {
            List<Patient> Patients = this.ToList();

            return Patients.Find(p=>p.Bar_Code_Patient.Equals(BarCode));

        }//end GetPatien

    }//end class 
}//end project 
