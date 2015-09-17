using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Windows.ApplicationModel;

namespace MVVM.Models
{
    public class Person: INotifyPropertyChanged
    {
        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }

        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        private string fullname;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set
            {
                fullname = value;
                OnPropertyChanged("FullName");
            }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }

        public Person()
        {
            if(DesignMode.DesignModeEnabled)
            {
                this.FirstName = "Mohamed";
                this.LastName = "Emam";
                this.Gender = "male";
            }
            else
            {
                this.FirstName = "";
                this.LastName = "";
                this.Gender = "female";
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
