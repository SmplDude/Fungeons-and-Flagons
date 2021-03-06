﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FandF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharacterInfoPage : ContentPage
	{
        CharacterInfo vm;
        public CharacterInfoPage (CharacterInfo cm)
		{
			InitializeComponent ();
            BindingContext = this.vm = cm;
            ItemsListView.ItemsSource = cm.allItems();
        }
	}
}
