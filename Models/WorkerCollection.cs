using System.Collections.ObjectModel;
using System.Linq;

namespace MedocScanner.Models
{
    public  class WorkerCollection : ObservableCollection<Worker>
    {


        /// <summary>
        /// return an empty worker( Doctor or Pharmacist )
        /// </summary>
        public Worker GetWorkerSelected(string workerTypeSelected)
        {
            if (!string.IsNullOrEmpty(workerTypeSelected))
            {
                if (workerTypeSelected.Equals("Médecin"))
                {
                    return new Doctor();
                }
                else if (workerTypeSelected.Equals("Pharmacien"))
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






        /// <summary>
        /// return worker, Doctor or Pharmacist , if the password is right , or null 
        /// </summary>
        public Worker GetWorkerConected(string password)
        {
            return this.ToList().Find(d => d.Password.Equals(password));
        }

    }//end class 
}//end project 
