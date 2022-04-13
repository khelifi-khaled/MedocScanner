using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public class Patient
    {
        private string _idPatient;
        private string _firstNamePatient;
        private string _lastNamePatient;
        private string _descriptionPatient;
        private DateTime _createdDatePatient;
        private bool _patientGender;
        private DateTime _patientBirthday;
        private string _patientAdress;
        private List<Medicine> _medicines;

        public  Patient() { }

        public Patient(DateTime createdDatePatient,DateTime PatientBirthday, string idPatient="0",string firstNamePatient="",string lastNamePatient="",string descriptionPatient="" , bool patientGender = true,string PatientAdress="", List<Medicine> medicines=null) 
        {
            _idPatient=idPatient;
            _firstNamePatient=firstNamePatient;
            _lastNamePatient=lastNamePatient;
            _descriptionPatient=descriptionPatient;
            _patientGender=patientGender;
            _createdDatePatient=createdDatePatient;
            _patientGender = patientGender;
            _patientBirthday = PatientBirthday;
            _patientAdress=PatientAdress;
            _medicines=medicines;
        }

        public string IdPatient
        {
            get =>  _idPatient; 
            set { _idPatient = value; }
        }

        public string FirstNamePatient
        {
            get =>  _firstNamePatient; 
            set { _firstNamePatient = value; }
        }

        public string LastNamePatient
        {
            get => _lastNamePatient; 
            set { _lastNamePatient = value; }
        }

        public string DescriptionPatient
        {
            get => _descriptionPatient;
            set { _descriptionPatient = value; }
        }

        public bool PatientGender
        {
            get => _patientGender;
            set { _patientGender = value; }
        }

        public DateTime CreatedDatePatient
        {
            get => _createdDatePatient;
            set { _createdDatePatient = value; }
        }

        public DateTime PatientBirthday
        {
            get => _patientBirthday;
            set { _patientBirthday = value; }
        }

        public string PatientAdress
        {
            get => _patientAdress;
            set { _patientAdress = value; }
        }

        public List<Medicine> Medicines
        {
            get => _medicines;
            set { _medicines = value; }
        }

    }//end class 
}//end project
