using MedocScanner.Utilities.Interfaces;
using System.Text.RegularExpressions;
using System.Windows;

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
                if (ChekEmail(value))
                {
                    _workerEmail = value;
                }
                
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
        /// Check if the entry Email from DB is the right  for this Worker
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if Email Formate is correct</returns>
        public bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);

        }//end IsValidEmail



        /// <summary>
        /// Check if the entry Email from DB is the right  for this Worker
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if Email Formate is correct</returns>
        public  bool ChekEmail(string email)
        {
            if (IsValidEmail(email))
            {
                return true; 
            }else
            {
                MessageBox.Show($"le Formate de Mail de {this.FullName} est incorect !");
                return false;
            }//end if 
        }//end ChekEmail




    }//end class 

}//end project
