using System;


namespace MedocScanner.Models
{
    public class Prescription
    {
        private uint _idPrescription;
        private DateTime _prescriptionDate ;
        private Patient _patient;
        private Worker _doctor;
        private MedicineCollection _medicines;

        public Prescription() { }

        public Prescription(DateTime prescriptionDate, uint idPrescription = 0,  Patient patient = null, Worker doctor = null, MedicineCollection medicines=null)
        {
            _idPrescription = idPrescription;
            _prescriptionDate = prescriptionDate;
            _patient= patient;
            _doctor= doctor;
            _medicines= medicines;
        }

       
        

        public MedicineCollection Medicines
        {
            get => _medicines;
            set
            {
                _medicines = value;
            }
        }

        public uint IdPrescription
        {
            get => _idPrescription;
            set
            {
                _idPrescription = value;
            }
        }


        public DateTime PrescriptionDate
        {
            get => _prescriptionDate;
            set
            {
                _prescriptionDate = value;
            }
        }

        public Patient Patient 
        {
            get => _patient;
            set
            {
                _patient = value;
            }
        }

        public Worker Doctor 
        {
            get => _doctor;
            set
            {
                _doctor = value;
            }
        }

       


    }//end class 

}//end project 
