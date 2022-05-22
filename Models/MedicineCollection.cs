using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MedocScanner.Models
{
    public class MedicineCollection : ObservableCollection<Medicine>
    {



        /// <summary>
        /// Add Medicine to this list of Medicines if the Medicine don't exist in this list, if exist =>MessageBox.Show....
        /// </summary>
        /// <param name="medicine"></param>
        
        public void AddMedicine(Medicine medicine)
        {
            bool flag = false;

            for (int i = 0; i < this.Count; i++)
            {
                if(this[i].IdMedecine.Equals(medicine.IdMedecine))
                {
                    flag = true;

                }//end if 
            }//end for loop 

            if (flag)
            {
                MessageBox.Show("Le médicament existe déjà dans la liste des médicaments de cette prescription. ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                this.Add(medicine);
            }
        }//end AddMedicine





        /// <summary>
        /// Get the Medicine that we are looking for, from this list, throw the Medicine BarCode  
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns>Medicine thant we are looking for</returns>

        public Medicine GetMedicine(string BarCode)
        {
            List<Medicine> Medicines = this.ToList();

            return Medicines.Find(m => m.Bar_Code_Medecine.Equals(BarCode));
        }//end GetMedicine



        /// <summary>
        /// collect us all the  prices of Medicines in this MedicineCollection
        /// </summary>
        /// <returns>Double (price HTVA of all Medicines in this list)</returns>
        public double GetMedicinesPrice()
        {
            double price = 0.0;
            this.ToList().ForEach(m => price += m.MedecinePrice);
            return price;
        }

    }//end class 
}//end priject 
