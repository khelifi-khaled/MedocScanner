using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public  class PrescriptionCollection : ObservableCollection<Prescription>
    {

        public uint GetPrescriptionId()
        {
            if (this.Count==0)
            {
                return 1;
            }
            else
            {
                return (uint)this.Count() + 1;
            }
        }

    }//end class 
}//end project 
