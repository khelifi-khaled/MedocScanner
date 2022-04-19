using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public  class WorkerCollection : ObservableCollection<Worker>
    {



        public Worker GetWorkerSelected(string workerTypeSelected)
        {
            if (!string.IsNullOrEmpty(workerTypeSelected))
            {
                if (workerTypeSelected.Equals("Doctor"))
                {
                    return new Doctor();
                }
                else if (workerTypeSelected.Equals("Pharmacist"))
                {
                    return new Pharmacist();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }//end GetWorkerSelected


        public Worker GetWorkerConected(string password)
        {
            return this.ToList().Find(d => d.Password.Equals(password));
        }

    }//end class 
}//end project 
