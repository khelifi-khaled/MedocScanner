using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public  class PrescriptionCollection : ObservableCollection<Prescription>
    {

        public int GetPrescriptionId()
        {
            return( this.Count == 0) ? 1 : this.Count + 1;
        }

    }//end class 
}//end project 
