




namespace MedocScanner.Models
{
    public  class Pharmacist : Worker
    {


        public Pharmacist() { }

        public Pharmacist(string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "",int workerId=0) : base(password, firstName, lastName, workerEmail, phoneWorker, hWorkerAdress, WorkerAdress,workerId)
        {

        }


        public override bool IsRightPassword(string tryPassword)
        {
            return tryPassword.Equals(this.Password);

        }//END IsRightPassword
    }//end class 
}//end project 
