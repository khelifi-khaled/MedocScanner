using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public  class PrescriptionCollection : ObservableCollection<Prescription>
    {

        /// <summary>
        /// Check the number of Prescriptions in this list, if the number of Prescriptions 0 return 1,
        /// else return the number of priscriptions +1
        /// </summary>
        /// <returns> int correct PrescriptionId </returns>
        public int GetPrescriptionId()
        {
            return( this.Count == 0) ? 1 : this.Count + 1;
        }

    }//end class 
}//end project 
