using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace StudentHelper.ViewModels
{
    public class InfoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isSavable;

        public string Faculty
        {
            get { return Data.CurrentTerm.Info.Faculty; }
            set
            {
                if (Data.CurrentTerm.Info.Faculty != value)
                {
                    Data.CurrentTerm.Info.Faculty = value;
                    IsSaveable = true;
                    OnPropertyChanged("Faculty");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public string Cathedra
        {
            get { return Data.CurrentTerm.Info.Cathedra; }
            set
            {
                if (Data.CurrentTerm.Info.Cathedra != value)
                {
                    Data.CurrentTerm.Info.Cathedra = value;
                    IsSaveable = true;
                    OnPropertyChanged("Cathedra");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public string Direction
        {
            get { return Data.CurrentTerm.Info.Direction; }
            set
            {
                if (Data.CurrentTerm.Info.Direction != value)
                {
                    Data.CurrentTerm.Info.Direction = value;
                    IsSaveable = true;
                    OnPropertyChanged("Direction");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public string Speciality
        {
            get { return Data.CurrentTerm.Info.Speciality; }
            set
            {
                if (Data.CurrentTerm.Info.Speciality != value)
                {
                    Data.CurrentTerm.Info.Speciality = value;
                    IsSaveable = true;
                    OnPropertyChanged("Speciality");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public string Group
        {
            get { return Data.CurrentTerm.Info.Group; }
            set
            {
                if (Data.CurrentTerm.Info.Group != value)
                {
                    Data.CurrentTerm.Info.Group = value;
                    IsSaveable = true;
                    OnPropertyChanged("Group");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public DateTime StartDate
        {
            get { return Data.CurrentTerm.StartDate; }
            set
            {
                if (Data.CurrentTerm.StartDate != value)
                {
                    Data.CurrentTerm.StartDate = value;
                    IsSaveable = true;
                    OnPropertyChanged("StartDate");
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        public bool IsSaveable
        {
            get { return isSavable; }
            set
            {
                if (isSavable != value)
                {
                    isSavable = value;
                    OnPropertyChanged("IsSaveable");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
