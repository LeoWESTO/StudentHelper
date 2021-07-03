﻿using StudentHelper.Models;
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
	public partial class HomeworkEditPage : ContentPage
	{
        HomeworkEditViewModel vm;
		public HomeworkEditPage (Homework hw)
		{
			InitializeComponent();
            vm = new HomeworkEditViewModel(hw);
            BindingContext = vm;
		}

        private void AddHomework(object sender, EventArgs e)
        {
            
        }
    }
}