using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace MedocScanner.Models
{
    public class PharmacistCollection : ObservableCollection<Pharmacist>
    {





        /// <summary>
        /// try to find a Pharmacist in the collection by his/her tryPassword
        /// </summary>
        /// <param name="tryPassword"></param>
        /// <returns>reference to the Pharmacist in this Pharmacist's collection, with a match on the Password</returns>
        public Pharmacist getPharmacist(string tryPassword)
        {
            return this.ToList().Find(p => p.Password.Equals(tryPassword));
        }



    }//end class 
}//end project 
