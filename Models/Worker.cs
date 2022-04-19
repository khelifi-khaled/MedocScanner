

namespace MedocScanner.Models
{
    public abstract class Worker
    {
       
        private string _password;
        private string  _firstName;
        private string _lastName;
        private string _workerEmail;
        private string _phoneWorker;
        private string _hWorkerAdress;
        private string _workerAdress;

       public  Worker() { }

        public Worker( string  password="",string firstName="",string lastName="",string workerEmail = "",string phoneWorker = "",string  hWorkerAdress="",string WorkerAdress="")
        {
            _password= password;
            _firstName= firstName;
            _lastName= lastName;
            _workerEmail= workerEmail;
            _phoneWorker= phoneWorker;
            _hWorkerAdress= hWorkerAdress;
            _workerAdress = WorkerAdress;
        }//end constructeur



       
        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
            set
            {

            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }


        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        public string WorkerEmail
        {
            get
            {
                return _workerEmail;
            }
            set
            {
                _workerEmail = value;
            }
        }


        public string PhoneWorker
        {
            get
            {
                return _phoneWorker;
            }
            set
            {
                _phoneWorker = value;
            }
        }

        public string H_WorkerAdress
        {
            get
            {
                return _hWorkerAdress;
            }
            set
            {
                _hWorkerAdress = value;
            }
        }

        public string  WorkerAdress
        {
            get
            {
                return _workerAdress;
            }
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
