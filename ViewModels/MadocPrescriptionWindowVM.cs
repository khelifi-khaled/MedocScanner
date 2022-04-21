using MedocScanner.Models;
using System.ComponentModel;


namespace MedocScanner.ViewModels
{
    public  class MadocPrescriptionWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public MadocPrescriptionWindowVM(Prescription prescription)
        {
            Prescription = prescription;
        }


        public Prescription Prescription { get; set; }

        public double Totalprice
        {
            get
            {
                return Prescription.Medicines.GetMedicinesPrice();
            }
            set { }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }//end class 
}//end project 
