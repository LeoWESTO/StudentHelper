using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewInfoPage : ContentPage
    {
        public NewInfoPage()
        {
            InitializeComponent();
            numberLabel.Text = "1";
        }

        private void NumberStepper(object sender, ValueChangedEventArgs e)
        {
            if (numberLabel != null) numberLabel.Text = e.NewValue.ToString();
            Data.CurrentTerm.Number = (int)e.NewValue;
        }
    }
}