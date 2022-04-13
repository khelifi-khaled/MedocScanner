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
        /// retrieve Doctors's informations from the external source
        /// </summary>
        /// <returns>a DoctorCollection </returns>
        DoctorCollection GetDoctorsDatas();


        /// <summary>
        /// retrieve Pharmacist's informations from the external source
        /// </summary>
        /// <returns>a PharmacistCollection </returns>
        PharmacistCollection GetPharmacistsDatas();


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
        /// update all Doctors datas from the Doctor collection to the external source
        /// </summary>
        /// <param name="ds"></param>
        void UpdateAllDoctorsDatas(DoctorCollection ds);

        /// <summary>
        /// update all Pharmacists datas from the Pharmacist collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        void UpdateAllPharmacistsDatas(PharmacistCollection ps);



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
        

    }
}
