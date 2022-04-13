using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public  class Doctor : Worker
    {
        private List<Patient> _patientsDoctor;

        public  Doctor() { }

        public Doctor(List<Patient> patientsDoctor = null, string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "") : base(password, firstName, lastName, workerEmail, hWorkerAdress, WorkerAdress, phoneWorker)
        {
            _patientsDoctor = patientsDoctor;
        }



        public List<Patient> PatientsDoctor
        {
            get => _patientsDoctor;
            set { _patientsDoctor = value; }
        }



        public override bool IsRightPassword(string tryPassword)
        {
            return tryPassword.Equals(this.Password);

        }//END IsRightPassword
    }
}
