using MedocScanner.Utilities.Interfaces;
using System;
using System.Net.Mail;
using System.Windows;

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



        /// <summary>
        /// Check if the entry Email from DB is the right  for this Worker
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if Email Formate is correct</returns>
        public override bool IsValid_Email(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                if (string.IsNullOrEmpty(emailaddress))
                {
                    MessageBox.Show($"Email mancent.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show($"Email incorrect.", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                return false;
            }
        }



    }//end class 
}//end project 
