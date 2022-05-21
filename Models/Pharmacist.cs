using MedocScanner.Utilities.Interfaces;

namespace MedocScanner.Models
{
    public  class Pharmacist : Worker, IWorker
    {


        public Pharmacist() { }

        public Pharmacist(string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "",int workerId=0) : base(password, firstName, lastName, workerEmail, phoneWorker, hWorkerAdress, WorkerAdress,workerId)
        {

        }


      
    }//end class 
}//end project 
