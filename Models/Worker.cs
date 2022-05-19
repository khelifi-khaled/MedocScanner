using MedocScanner.Utilities.Interfaces;

namespace MedocScanner.Models
{
    public abstract class Worker : IWorker
    {
        private int _workerId;
        private string _password;
        private string  _firstName;
        private string _lastName;
        private string _workerEmail;
        private string _phoneWorker;
        private string _hWorkerAdress;
        private string _workerAdress;

       public  Worker() { }

        public Worker( string  password="",string firstName="",string lastName="",string workerEmail = "",string phoneWorker = "",string  hWorkerAdress="",string WorkerAdress="",int workerId=0)
        {
            _password= password;
            _firstName= firstName;
            _lastName= lastName;
            _workerEmail= workerEmail;
            _phoneWorker= phoneWorker;
            _hWorkerAdress= hWorkerAdress;
            _workerAdress = WorkerAdress;
            _workerId = workerId;
        }//end constructeur


        public int WorkerId
        {
            get => _workerId;
            set
            {
                _workerId = value;
            }
        }


        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
            set { }

        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
            }
        }


        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
            }
        }


        public string LastName
        {
            get=> _lastName;
            set
            {
                _lastName = value;
            }
        }


        public string WorkerEmail
        {
            get=> _workerEmail;
            set
            {
                _workerEmail = value;
            }
        }


        public string PhoneWorker
        {
            get => _phoneWorker;
            set
            {
                _phoneWorker = value;
            }
        }

        public string H_WorkerAdress
        {
            get=> _hWorkerAdress;
            set
            {
                _hWorkerAdress = value;
            }
        }

        public string  WorkerAdress
        {
            get => _workerAdress;
            set
            {
                _workerAdress = value;
            }
        }


        /// <summary>
        /// Check if the entry password is the right password for this Worker
        /// </summary>
        /// <param name="tryPassword"></param>
        /// <returns>true if password is correct</returns>
        public abstract bool IsRightPassword(string tryPassword) ;

        

    }//end class 

}//end project
