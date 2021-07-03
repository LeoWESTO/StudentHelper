using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudentHelper.ViewModels
{
    public class NewInfoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Number
        {
            get { return Data.CurrentTerm.Number; }
            set
            {
                Data.CurrentTerm.Number = value;
                OnPropertyChanged("Number");
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
