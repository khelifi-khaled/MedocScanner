using System;


namespace MedocScanner.Models
{
    public class Prescription
    {
        private int _idPrescription;
        private DateTime _prescriptionDate ;
        private Patient _patient;
        private Doctor _doctor;
        private MedicineCollection _medicines;

        public Prescription() { }

        public Prescription(DateTime prescriptionDate, int idPrescription = 0,  Patient patient = null, Doctor doctor = null)
        {
            _idPrescription = idPrescription;
            _prescriptionDate = prescriptionDate;
            _patient= patient;
            _doctor= doctor;
            Medicines=new MedicineCollection();
        }



        /// <summary>
        /// Medicines of the patien of this prescription 
        /// </summary>
        public MedicineCollection Medicines
        {
            get => _medicines;
            set
            {
                _medicines = value;
            }
        }


        /// <summary>
        /// Id of Prescription coming from DB 
        /// </summary>
        public int IdPrescription
        {
            get => _idPrescription;
            set
            {
                _idPrescription = value;
            }
        }

        /// <summary>
        /// the date of creation of this prescription 
        /// </summary>
        public DateTime PrescriptionDate
        {
            get => _prescriptionDate;
            set
            {
                _prescriptionDate = value;
            }
        }




        /// <summary>
        /// the Patient of this prescription 
        /// </summary>
        public Patient Patient 
        {
            get => _patient;
            set
            {
                _patient = value;
            }
        }



        /// <summary>
        /// the doctor who  create  this prescription 
        /// </summary>
        public Doctor Doctor 
        {
            get => _doctor;
            set
            {
                _doctor = value;
            }
        }

       


    }//end class 

}//end project 
