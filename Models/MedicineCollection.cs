using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace MedocScanner.Models
{
    public class MedicineCollection : ObservableCollection<Medicine>
    {

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
                MessageBox.Show("le medoc existe deja dans la liste des medocs de ce patient ", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                this.Add(medicine);
            }
        }//end AddMedicine

        public Medicine GetMedicine(string BarCode)
        {
            List<Medicine> Medicines = this.ToList();

            return Medicines.Find(m => m.IdMedecine.Equals(BarCode));
        }//end GetMedicine


        public double GetMedicinesPrice()
        {
            double price = 0.0;
            this.ToList().ForEach(m => price += m.MedecinePrice);
            return price;
        }

    }//end class 
}//end priject 
