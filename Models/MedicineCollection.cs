using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public class MedicineCollection : ObservableCollection<Medicine>
    {






        public Medicine GetMedicine(string BarCode)
        {
            List<Medicine> Medicines = this.ToList();

            return Medicines.Find(m => m.IdMedecine.Equals(BarCode));
        }

    }//end class 
}//end priject 
