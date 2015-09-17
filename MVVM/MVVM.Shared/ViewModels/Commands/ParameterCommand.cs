using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MVVM.Models;

namespace MVVM.ViewModels.Commands
{
    public class ParameterCommand: ICommand
    {
        public ViewModelBase ViewModel{ get; set; }
        public ParameterCommand(ViewModelBase viewModel)
        {
            this.ViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //if(parameter !=null)
            //{
            //    //var s = parameter as String;
            //    //s = s.Trim();
            //    //if(string.IsNullOrEmpty(s))
            //    //    return false;

            //    //return true;

            //    //var p = parameter as Person;
            //    //p.FirstName = p.FirstName.Trim();
            //    //p.LastName = p.LastName.Trim();
            //    //if(string.IsNullOrEmpty(p.FirstName))
            //    //    return false;
            //    //if(string.IsNullOrEmpty(p.LastName))
            //    //    return false;
            //    //return true;
            //}
                return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.ParameterMethod(parameter as Person);
        }
    }
}
