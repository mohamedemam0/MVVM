using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;
using MVVM.Models;
using MVVM.ViewModels.Commands;
using Windows.ApplicationModel;

namespace MVVM.ViewModels
{
    public class ViewModelBase: ObservableCollection<Person>
    {
        public SimpleCommand SimpleCommand { get; set; }
        public ParameterCommand ParameterCommand{ get; set; }
        public ViewModelBase()
        {
            this.SimpleCommand = new SimpleCommand(this);
            this.ParameterCommand = new ParameterCommand(this);

            if(DesignMode.DesignModeEnabled)
            {
                for(int i = 1; i <+ 10; i++)
                {
                    Add(new Person()
                    {
                        FirstName = "Person " + i,
                        LastName = "LastName " + i,
                        Gender = "female"
                    });
                }
                Add(new Person()
                {
                    FirstName = "Person ",
                    LastName = "LastName ",
                    Gender = "male"
                });
            }
        }


        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }

        public void ParameterMethod(Person person)
        {
            Person p = new Person();
            p.Gender = person.Gender;
            p.FirstName = person.FirstName;
            p.LastName = person.LastName;
            Add(p);
        }
    }
}
