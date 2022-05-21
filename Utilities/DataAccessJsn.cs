using MedocScanner.Models;
using Newtonsoft.Json;
using System;
using System.IO;


namespace MedocScanner.Utilities
{
    public  class DataAccessJsn : DataAccess
    {

        public DataAccessJsn(string filePath) : base(filePath) { }

        public DataAccessJsn( string filePath, string[] extensions) : base(filePath, extensions) { }


        /// <summary>
        /// retrieve Workers's informations from the external source
        /// </summary>
        /// <returns>a WorkerCollection </returns>
        public override WorkerCollection GetWorkersDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                WorkerCollection Workers = new WorkerCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (Worker)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Workers = JsonConvert.DeserializeObject<WorkerCollection>(jsonFile, settings);

                return Workers;
            }
            else
            {
                return null;
            }
        }//end GetWorkersDatas




        



        /// <summary>
        /// retrieve Medicine's informations from the external source
        /// </summary>
        /// <returns>a MedicineCollection </returns>
        public override MedicineCollection GetMedicinesDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                MedicineCollection Medicines = new MedicineCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (User)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Medicines = JsonConvert.DeserializeObject<MedicineCollection>(jsonFile, settings);

                return Medicines;
            }
            else
            {
                return null;
            }
        }//end GetMedicinesDatas




        /// <summary>
        /// retrieve Patient's informations from the external source
        /// </summary>
        /// <returns>a PatientCollection </returns>
        public override PatientCollection GetPatientsDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                PatientCollection Patients = new PatientCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (User)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Patients = JsonConvert.DeserializeObject<PatientCollection>(jsonFile, settings);

                return Patients;
            }
            else
            {
                return null;
            }
        }//end GetPatientsDatas



        public override void UpdateAllPrescriptionsDatas(PrescriptionCollection ps)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(ps, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllDoctorsDatas error can't update datasource file");
            }
        }

        public  void UpdateAllWorkerDatas(WorkerCollection ps)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(ps, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllDoctorsDatas error can't update datasource file");
            }
        }


        public override PrescriptionCollection GetPrescriptionsDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                PrescriptionCollection Prescriptions = new PrescriptionCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (User)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Prescriptions = JsonConvert.DeserializeObject<PrescriptionCollection>(jsonFile, settings);

                return Prescriptions;
            }
            else
            {
                return null;
            }
        }




    }//end class 
}//end project 
