using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mvvm_demo.Models;

namespace mvvm_demo.Viewmodels
{
    public class MainWindowViewmodel : INotifyPropertyChanged
    {
        private PersonModel _Model;
        private string _FullName;
        private ICommand _RelayCommandFirstName;
        private ICommand _RelayCommandLastName;
        
        public MainWindowViewmodel()
        {
            _Model = new PersonModel();
            //_Model.FirstName = "Jan";
            //_Model.LastName = "de Wit";
            this.FullName = String.Format("{0} {1}", _Model.FirstName, _Model.LastName);
            
        }

   
        public ICommand CommandStelVoornaamIn { 
            get { 
                if(_RelayCommandFirstName==null)
                {
                    _RelayCommandFirstName = new RelayCommand(p => StelVoornaamIn(p),true);
                }
                
                return _RelayCommandFirstName; } 
            set { _RelayCommandFirstName = value; } 
        }

        public ICommand CommandStelAchternaamIn
        {
            get
            {
                if (_RelayCommandLastName == null)
                {
                    _RelayCommandLastName = new RelayCommand(p => StelAchternaamIn(p), true);
                }

                return _RelayCommandLastName;
            }
            set { _RelayCommandLastName = value; }
        }

        public void StelVoornaamIn(object o)
        {
            this.FirstName = (string)o;
        }

        public void StelAchternaamIn(object o)
        {
            this.LastName = (string)o;
        }

        public string FirstName {
            get { return _Model.FirstName; }
            set { 
                _Model.FirstName = value;
                this.FullName = String.Format("{0} {1}", _Model.FirstName, _Model.LastName);
                OnPropertyChanged("FirstName");
            } 
        }

        public string LastName
        {
            get { return _Model.LastName; }
            set
            {
                _Model.LastName = value;
                this.FullName = String.Format("{0} {1}", _Model.FirstName, _Model.LastName);
                OnPropertyChanged("LastName");
            }
        }


        public string FullName { 
            get { return _FullName; }
            set { 
                _FullName = value;
                OnPropertyChanged("FullName");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
