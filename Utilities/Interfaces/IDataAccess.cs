using MedocScanner.Models;


namespace MedocScanner.Utilities.Interfaces
{
    public  interface IDataAccess
    {
        /// <summary>
        /// Access string to the external source (file path, connections tring ...)
        /// </summary>
        string AccessPath
        {
            get;
            set;
        }


        /// <summary>
        /// retrieve Prescription's informations from the external source
        /// </summary>
        /// <returns>a PrescriptionCollection </returns>
        PrescriptionCollection GetPrescriptionsDatas();

        /// <summary>
        /// retrieve Worker's informations from the external source
        /// </summary>
        /// <returns>a WorkerCollection </returns>
        WorkerCollection GetWorkersDatas();


        /// <summary>
        /// retrieve Medicine's informations from the external source
        /// </summary>
        /// <returns>a MedicineCollection </returns>
        MedicineCollection GetMedicinesDatas();




        /// <summary>
        /// retrieve Patient's informations from the external source
        /// </summary>
        /// <returns>a PatientCollection </returns>
        PatientCollection GetPatientsDatas();





        /// <summary>
        /// update all Prescriptions datas from the Prescription collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        void UpdateAllPrescriptionsDatas(PrescriptionCollection ps);


    }
}
