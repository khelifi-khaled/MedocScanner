



namespace MedocScanner.Models
{
    public  class Doctor : Worker
    {
       

        public  Doctor() { }

        public Doctor( string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "") : base(password, firstName, lastName, workerEmail, phoneWorker, hWorkerAdress, WorkerAdress)
        {

        }




        public override bool IsRightPassword(string tryPassword)
        {
            return tryPassword.Equals(this.Password);

        }//END IsRightPassword
    }
}
