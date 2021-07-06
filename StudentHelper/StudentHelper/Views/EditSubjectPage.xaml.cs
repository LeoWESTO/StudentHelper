using StudentHelper.Models;
using StudentHelper.ViewModels;
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
    public partial class EditSubjectPage : ContentPage
    {
        private EditSubjectViewModel vm;

        public EditSubjectPage(Subject subject = null)
        {
            InitializeComponent();
            vm = new EditSubjectViewModel(subject, Navigation);
            BindingContext = vm;
        }
    }
}