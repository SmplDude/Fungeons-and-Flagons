﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using FandF.Views;
using FandF.Services;
using System.Collections.ObjectModel;

namespace FandF
{
    public partial class CharacterPage : ContentPage
    {
        DBCharacterController dataAccess;

        public CharacterPage()
        {
            InitializeComponent();

            BindingContext = dataAccess = new DBCharacterController();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as CharacterDBModel;
            if (item == null)
                return;

            await Navigation.PushAsync(new CharacterDetailPage(new CharacterDetailViewModel(item)));

            // Manually deselect item
            CharactersListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCharacterPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // The instance of CustomersDataAccess
            // is the data binding source
            this.BindingContext = this.dataAccess;
        }
    }
}
