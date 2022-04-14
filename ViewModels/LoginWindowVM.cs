using MedocScanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedocScanner.ViewModels
{
    public  class LoginWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private string[] _listTypeWorker = { "Doctor", "Pharmacist"};

        public LoginWindowVM()
        {

        }



        public string[] ListTypeWorker
        {
            get => _listTypeWorker; 
            set
            {
                _listTypeWorker = value;
                OnPropertyChanged(nameof(ListTypeWorker));
            }
        }


        public Worker WorkerSelected
        {
            get;set;
        }




        public string  WorkerTypeStected
        {
            get;set;
        }



        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }//end class 
}//end project 
