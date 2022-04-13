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
        /// retrieve Doctors's informations from the external source
        /// </summary>
        /// <returns>a DoctorCollection </returns>
        public override DoctorCollection GetDoctorsDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                DoctorCollection Doctors = new DoctorCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (User)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Doctors = JsonConvert.DeserializeObject<DoctorCollection>(jsonFile, settings);

                return Doctors;
            }
            else
            {
                return null;
            }
        }//end GetDoctorsDatas




        /// <summary>
        /// retrieve Pharmacist's informations from the external source
        /// </summary>
        /// <returns>a PharmacistCollection </returns>
        public override PharmacistCollection GetPharmacistsDatas()
        {
            if (IsValidAccessPath)
            {
                string jsonFile = File.ReadAllText(AccessPath);

                PharmacistCollection Pharmacists = new PharmacistCollection();

                //settings are necessary to get also specific properties of the derivated class
                //and not only common properties of the base class (User)

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                Pharmacists = JsonConvert.DeserializeObject<PharmacistCollection>(jsonFile, settings);

                return Pharmacists;
            }
            else
            {
                return null;
            }
        }//end GetPharmacistsDatas



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




        /// <summary>
        /// update all Doctors datas from the Doctor collection to the external source
        /// </summary>
        /// <param name="ds"></param>
        public override void UpdateAllDoctorsDatas(DoctorCollection ds)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(ds, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllDoctorsDatas error can't update datasource file");
            }
        }//end UpdateAllDoctorsDatas


        /// <summary>
        /// update all Pharmacists datas from the Pharmacist collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        public override void UpdateAllPharmacistsDatas(PharmacistCollection ps)
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

        }// end  UpdateAllPharmacistsDatas


        /// <summary>
        /// update all Medicines datas from the Medicine collection to the external source
        /// </summary>
        /// <param name="ms"></param>
        public override void UpdateAllMedicinesDatas(MedicineCollection ms)
        {
            if (IsValidAccessPath)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

                string json = JsonConvert.SerializeObject(ms, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented, settings);

                File.WriteAllText(AccessPath, json);
            }
            else
            {
                Console.WriteLine("UpdateAllDoctorsDatas error can't update datasource file");
            }
        }//end UpdateAllMedicinesDatas


        /// <summary>
        /// update all Patients datas from the Patient collection to the external source
        /// </summary>
        /// <param name="ps"></param>
        public override void UpdateAllPatientsDatas(PatientCollection ps)
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
        }//end UpdateAllPatientsDatas

    }//end class 
}//end project 
