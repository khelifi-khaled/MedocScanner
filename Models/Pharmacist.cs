﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public  class Pharmacist : Worker
    {


        public Pharmacist() { }

        public Pharmacist(string password = "", string firstName = "", string lastName = "", string workerEmail = "", string phoneWorker = "", string hWorkerAdress = "", string WorkerAdress = "") : base(password, firstName, lastName, workerEmail, phoneWorker, hWorkerAdress, WorkerAdress)
        {

        }







        public override bool IsRightPassword(string tryPassword)
        {
            return tryPassword.Equals(this.Password);

        }//END IsRightPassword
    }//end class 
}//end project 