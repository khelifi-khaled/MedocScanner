using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public class Prescription
    {
        private uint _idPrescription;
        private DateTime _prescriptionDate ;
        private Patient _patient;
        private Doctor _doctor;



        public Prescription() { }

        public Prescription(DateTime prescriptionDate, uint idPrescription = 0,  Patient patient = null, Doctor doctor = null)
        {
            _idPrescription = idPrescription;
            _prescriptionDate = prescriptionDate;
            _patient= patient;
            _doctor= doctor;
        }

        public Prescription(DateTime prescriptionDate, uint idPrescription = 0)
        {
            _idPrescription = idPrescription;
            _prescriptionDate = prescriptionDate;
            
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
