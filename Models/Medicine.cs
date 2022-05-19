

namespace MedocScanner.Models
{
    public class Medicine
    {
        private int _idMedecine;
        private string _bar_Code_Medecine;
        private string _medecineDescription;
        private double _medecinePrice;

        public Medicine() { }

        public Medicine(int idMedecine = 0, string medecineDescription = "", double medecinePrice = 0.0, string bar_Code_Medecine="")
        {            
            _idMedecine = idMedecine;
            _bar_Code_Medecine= bar_Code_Medecine;
            _medecineDescription = medecineDescription;
            _medecinePrice = medecinePrice;

        }

        public string Bar_Code_Medecine
        {
            get => _bar_Code_Medecine;
            set
            {
                _bar_Code_Medecine = value;
            }
        }

        public int IdMedecine
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
