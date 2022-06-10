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


        /// <summary>
        ///  Medecine Bar Code Medecine 
        /// </summary>


        public string Bar_Code_Medecine
        {
            get => _bar_Code_Medecine;
            set
            {
                _bar_Code_Medecine = value;
            }
        }


        /// <summary>
        /// the number of  Medecine coming from DB
        /// </summary>
        public int IdMedecine
        {
            get => _idMedecine;


            set
            {
                _idMedecine = value;
            }
        }



        /// <summary>
        /// Medecine Description (Name .....)
        /// </summary>

        public string MedecineDescription
        {
            get => _medecineDescription; 
            set
            {
                _medecineDescription = value;
            }
        }



        /// <summary>
        /// the price of the medecine
        /// </summary>
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
