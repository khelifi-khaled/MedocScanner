using MedocScanner.Utilities.Interfaces;






namespace MedocScanner.Models
{
    
    public  class Doctor : Worker, IWorker
    {
        private string _inami;

        public  Doctor() { }

        public Doctor( string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "",string inami="",int workerId=0) : base(password, firstName, lastName, workerEmail, phoneWorker, hWorkerAdress, WorkerAdress, workerId)
        {
            _inami = inami;
        }

        public string Inami
        {
            get => _inami;
            set
            {
                _inami = value;
            }
        }


        



    }//end class 
}//end project 
