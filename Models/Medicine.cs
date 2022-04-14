using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.Models
{
    public class Medicine
    {
        private string _idMedecine;
        private string _medecineDescription;
        private double _medecinePrice;

        public Medicine() { }

        public Medicine(string idMedecine = "0", string medecineDescription = "", double medecinePrice = 0.0)
        {            
            _idMedecine = idMedecine;
            _medecineDescription = medecineDescription;
            _medecinePrice = medecinePrice;
        }

        public string IdMedecine
        {
            get => _idMedecine;


            set
            {
                _idMedecine = value;
            }
        }

        public string MedecineDescription
        {
            get => _medecineDescription; 
            set
            {
                _medecineDescription = value;
            }
        }

        public double MedecinePrice
        {
            get => _medecinePrice;   
            set
            {
                _medecinePrice = value;
            }
        }
       

    }//end class 
}//end project
