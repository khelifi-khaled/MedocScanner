using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace MedocScanner.Utilities
{
    public class DataAccessSQL 
    {

        public DataAccessSQL(string connString) 
        {

            SqlConnection = new SqlConnection(connString);
            SqlConnection.Open();
            Console.WriteLine("Connection to database opened !");
        }
        /// <summary>
        /// Connection String
        /// replaced by the connection string
        /// </summary>
        public  string AccessPath { get; set; }

        /// <summary>
        /// Connection to the database
        /// </summary>
        public SqlConnection SqlConnection { get; set; }




        /// <summary>
        /// retrieve Workers collection datas from DB
        /// </summary>
        public WorkerCollection GetWorkersDatas()
        {
            string sql = "SELECT * FROM Worker;";
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            WorkerCollection Workers = new WorkerCollection();

            while (dataReader.Read())
            {
                Worker w= GetWorker(dataReader);
                if (w != null)
                {
                    Workers.Add(w);
                }
            }
            dataReader.Close();
            return Workers;
        }

        /// <summary>
        /// retrieve 1  Worker  datas from DB 
        /// </summary>
        private Worker GetWorker(SqlDataReader dr)
        {
            string type = dr.GetValue(9).ToString().Trim().ToUpper();

            switch (type)
            {
                case "DOCTOR":
                    return new Doctor(dr.GetString(1),dr.GetString(2).Trim(),dr.GetString(3).Trim(), dr.GetString(4).Trim(), dr.GetString(5).Trim(), dr.GetString(6), dr.GetString(7), dr.GetString(8),dr.GetInt32(0));
                case "PHARMACIST":
                    return new Pharmacist(dr.GetString(1), dr.GetString(2).Trim(), dr.GetString(3).Trim(), dr.GetString(4).Trim(), dr.GetString(5).Trim(), dr.GetString(6).Trim(), dr.GetString(7).Trim(), dr.GetInt32(0));
                default:
                    MessageBox.Show($"SELECT sql error, le type {type} n'est pas reconnu", "Erreur de lecture", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;

            }//end switch case



        }//end GetWorker



        /// <summary>
        /// retrieve Medicines collection datas from DB
        /// </summary>

        public MedicineCollection GetMedicinesDatas()
        {
            string sql = "SELECT * FROM Medicine;";
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            MedicineCollection Medicines = new MedicineCollection();

            while (dataReader.Read())
            {
                Medicine w = GetMedicine(dataReader);
                if (w != null)
                {
                    Medicines.Add(w);
                }
            }
            dataReader.Close();
            return Medicines;
        }



        /// <summary>
        /// retrieve 1 Medicine datas from DB
        /// </summary>
        
        private Medicine GetMedicine(SqlDataReader dr)
        {
            
            return new Medicine(dr.GetInt32(0), dr.GetString(2), Double.Parse($"{ dr.GetValue(3)}"), dr.GetString(1));
        }

        /// <summary>
        /// retrieve Patients collection datas from DB
        /// </summary>
        public PatientCollection GetPatientDatas()
        {
            PatientCollection Patients = new PatientCollection();
            string sql = "SELECT * FROM Patient";
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
               
                Patient w = GetPatient(dataReader);
                if (w != null)
                {
                    Patients.Add(w);
                }
            }
            dataReader.Close();
            return Patients;
        }

        /// <summary>
        /// retrieve 1 Patient datas from DB
        /// </summary>

        private Patient GetPatient(SqlDataReader dr)
        {
            return new Patient(dr.GetDateTime(6), dr.GetString(1), dr.GetString(2).Trim(), dr.GetString(3).Trim(), dr.GetString(4), dr.GetBoolean(5),dr.GetString(7),dr.GetInt32(0));
        }


        /// <summary>
        /// retrieve Prescriptions collection datas from DB using 2 sql  query !!!
        /// </summary>
        public PrescriptionCollection GetPrescriptionsDatas()
        {
            PrescriptionCollection Prescriptions = new PrescriptionCollection();

            string sql = " select P.Id_Patient , P.Bar_cod_Patient,RTRIM(P.firstNamePatient),RTRIM(P.lastNamePatient),P.descriptionPatient,P.patientGender,P.patientBirthday,P.patientAdress,w.Id_worker,w.Pasword_Worker,RTRIM(w.firsteName),RTRIM(w.lasteName),RTRIM(w.workerEmail),RTRIM(w.phoneWorker),w.hWorkerAdress,w.workerAdress,w.INAMI,c.idPrescription,c.prescriptionDate " +
                "from Prescription c inner join Patient P on c.Id_Patient = P.Id_Patient inner join worker w on c.Id_worker = w.Id_worker; " +
                "select M.idMedecine , M.bar_Code_Medicine , M.medecineDescription,M.medecinePrice , P.idPrescription from Medicine M inner join Prescription_Medicines P on M.idMedecine = p.idMedecine";
           
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            
            SqlDataReader dataReader = cmd.ExecuteReader();

            
            while (dataReader.Read())
            {
                Prescription p = GetPrescription(dataReader);               
                if (p != null)
                {
                    Prescriptions.Add(p);
                }
            }


            //next Table of MedCollection with IdPriscription
            if (dataReader.NextResult())
            {
                
               GetMedicinCollectionSQL(dataReader,Prescriptions);
               

            }
            dataReader.Close();
            return Prescriptions;

        }


        /// <summary>
        /// retrieve 1 Prescription datas from DB
        /// </summary>

        private Prescription GetPrescription(SqlDataReader dr)
        {
            Prescription Thisprescription = new Prescription(dr.GetDateTime(18), dr.GetInt32(17), GetPatientSQL(dr), GetDoctorSQL(dr)) ;
            
            return Thisprescription; 
        }


        /// <summary>
        /// retrieve the patient of Thisprescription  from DB
        /// </summary>
        private Patient GetPatientSQL(SqlDataReader patientDr)
        {
            return new Patient(patientDr.GetDateTime(6), patientDr.GetString(1), patientDr.GetString(2), patientDr.GetString(3), patientDr.GetString(4), patientDr.GetBoolean(5), patientDr.GetString(7),patientDr.GetInt32(0)) ;
        }


        /// <summary>
        /// retrieve the Doctor of Thisprescription  from DB
        /// </summary>
        private Doctor GetDoctorSQL(SqlDataReader DoctorDr)
        {
            return new Doctor(DoctorDr.GetString(9),DoctorDr.GetString(10),DoctorDr.GetString(11),DoctorDr.GetString(12),DoctorDr.GetString(13),DoctorDr.GetString(14),DoctorDr.GetString(15),DoctorDr.GetString(16),DoctorDr.GetInt32(8));

        }

        /// <summary>
        /// retrieve Medicines collection of Thisprescription from DB
        /// </summary>

        private void GetMedicinCollectionSQL(SqlDataReader dr, PrescriptionCollection prescriptions)
        {
            while (dr.Read())
            {
                var mdoc = GetMedicine(dr);

                //loop on my prescription list 
                for (int i = 0; i< prescriptions.Count;i++)
                {
                    Console.WriteLine(dr.GetInt32(4));
                    Console.WriteLine(prescriptions[i].IdPrescription);
                    //injection of medoc in prescription list 
                    if (prescriptions[i].IdPrescription== dr.GetInt32(4))
                    {
                        prescriptions[i].Medicines.Add(mdoc);

                    }//end if 
                }
               
            }
            

        }//end GetMedicinCollectionSQL



        public void UpdateAllPrescriptionsDatas(PrescriptionCollection Prescriptions)
        {
            
                try
                {
                    string sql = string.Empty;
                    foreach (Prescription p in Prescriptions)
                    {
                        //if id Prescription already in databse, we don't do anythig , otherwise insert the new prescription 
                        if (!IsInDb(p.IdPrescription, "IdPrescription", "Prescription"))
                        {
                        sql = GetSqlInsert(p);

                            if (!string.IsNullOrEmpty(sql))
                            {
                                
                                SqlCommand command = new SqlCommand(sql, SqlConnection);
                                command.ExecuteNonQuery();
                            }
                        }
                    

                    }//end foreach

                SqlConnection.Close();
                MessageBox.Show("Sauvegarde effectuée");

            }//end try 
                catch (Exception e)
                {
                    MessageBox.Show($"insert or update sql request error {e.Message} ", "Erreur de suvegarde", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


        }//end UpdateAllPrescriptionsDatas

        private bool IsInDb(int id, string idName, string tableName)
        {
            string sql = $"SELECT * FROM {tableName} WHERE {idName} = {id}";
            SqlCommand cmd = new SqlCommand(sql, SqlConnection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            bool inDb = dataReader.HasRows;
            dataReader.Close();
            return inDb;
        }


        private string GetSqlInsert(Prescription thisPrescription)
        {
            //Insert in Prescription table 
            string sqlInsrt = $"SET DATEFORMAT DMY; INSERT INTO Prescription VALUES('{thisPrescription.PrescriptionDate}',{thisPrescription.Doctor.WorkerId},{thisPrescription.Patient.IdPatient});  ";

            //Insert in medoc  Prescription table 
            foreach (Medicine medoc in thisPrescription.Medicines)
            {
                sqlInsrt += $"INSERT INTO Prescription_Medicines VALUES ({thisPrescription.IdPrescription},{medoc.IdMedecine}); ";
            }

            return sqlInsrt;

        }//end GetSqlInsert


    }//end class 
}//end project 
