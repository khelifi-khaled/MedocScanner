using System;


namespace MedocScanner.Models
{
    public class Patient
    {
        private int _idPatient;
        private string _bar_Code_Patient;
        private string _firstNamePatient;
        private string _lastNamePatient;
        private string _descriptionPatient;
        private bool _patientGender;
        private DateTime _patientBirthday;
        private string _patientAdress;

        public  Patient() { }

        public Patient(DateTime PatientBirthday, string bar_Code_Patient = "0",string firstNamePatient="",string lastNamePatient="",string descriptionPatient="" , bool patientGender = true,string PatientAdress="",int idPatient=0) 
        {
            _bar_Code_Patient = bar_Code_Patient;
            _firstNamePatient=firstNamePatient;
            _lastNamePatient=lastNamePatient;
            _descriptionPatient=descriptionPatient;
            _patientGender=patientGender;
            _patientBirthday = PatientBirthday;
            _patientAdress=PatientAdress;
            _idPatient=idPatient;
          
        }

        public int IdPatient
        {
            get => _idPatient;
            set
            {
                _idPatient = value;
            }
        }
        public string FullName
        {
            get { return $"{_firstNamePatient} {_lastNamePatient}"; }
            set { }
        }

        public string Bar_Code_Patient
        {
            get => _bar_Code_Patient; 
            set { _bar_Code_Patient = value; }
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


    }//end class 
}//end project
