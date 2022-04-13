using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public  class DoctorCollection : ObservableCollection<Doctor> 
    {





        /// <summary>
        /// try to find a doctor in the collection by his/her tryPassword
        /// </summary>
        /// <param name="tryPassword"></param>
        /// <returns>reference to the Doctor in this Doctor's collection, with a match on the Password</returns>
        public Doctor getDoctor(string tryPassword)
        {
            return this.ToList().Find(w => w.Password.Equals(tryPassword)) ;
        }

    }//end class 
}//end  project 
