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
        /// update all Workers datas from the Worker collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        void UpdateAllWorkersDatas(WorkerCollection ps);



        /// <summary>
        /// update all Medicines datas from the Medicine collection to the external source
        /// </summary>
        /// <param name="ms"></param>
        void UpdateAllMedicinesDatas(MedicineCollection ms);



        /// <summary>
        /// update all Patients datas from the Patient collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        void UpdateAllPatientsDatas(PatientCollection ps);

        /// <summary>
        /// update all Prescriptions datas from the Prescription collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        void UpdateAllPrescriptionsDatas(PrescriptionCollection ps);


    }
}
