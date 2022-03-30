using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_demo.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;

        public string FirstName {
            get { return _firstname; }
            set { 
                _firstname = value;
                OnPropertyChanged("FirstName");
            } 
        }
        public string LastName {
            get { return _lastname; } 
            set { 
                _lastname = value;
                OnPropertyChanged("LastName");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
