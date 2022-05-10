using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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





        public WorkerCollection GetWorkersDatas()
        {
            string sql = "SELECT * FROM Workers;";
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


        private Worker GetWorker(SqlDataReader dr)
        {
            string type = dr.GetValue(1).ToString().Trim().ToUpper();

            switch (type)
            {
                case "DOCTOR":
                    return new Doctor(dr.GetString(0), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(2));
                case "PHARMACIST":
                    return new Pharmacist(dr.GetString(0), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));
                default:
                    MessageBox.Show($"SELECT sql error, le type {type} n'est pas reconnu", "Erreur de lecture", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;

            }//end switch case



        }//end GetWorker



        public MedicineCollection GetMedicinesDatas()
        {
            string sql = "SELECT * FROM Medicines;";
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

        private Medicine GetMedicine(SqlDataReader dr)
        {
            return new Medicine(dr.GetString(0), dr.GetString(1),Double.Parse(dr.GetDecimal(2).ToString()));
        }


        public PatientCollection GetPatientDatas()
        {
            PatientCollection Patients = new PatientCollection();
            string sql = "SELECT * FROM Patients";
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

        private Patient GetPatient(SqlDataReader dr)
        {
            return new Patient(dr.GetDateTime(5), dr.GetValue(0).ToString(), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4), dr.GetString(6));
        }



    }//end class 
    }//end project 
