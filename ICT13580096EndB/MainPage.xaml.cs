﻿using System;
using System.Collections.Generic;
using ICT13580096EndB.Model;
using Xamarin.Forms;

namespace ICT13580096EndB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			newButton.Clicked += NewButton_Clicked;

		}
		protected override void OnAppearing()
		{
			LoadData();
		}
		void LoadData()
		{
			productListView.ItemsSource = App.DbHelper.GetProducts();
		}

		void NewButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ProductNewPage());
		}

		void Edit_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as MenuItem;
			var product = button.CommandParameter as Product;
			Navigation.PushModalAsync(new ProductNewPage(product));
		}

		async void Delete_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as MenuItem;
			var product = button.CommandParameter as Product;

			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่หรือไม่", "ใช่", "ไม่ใช่");

			if (isOk)
			{
				App.DbHelper.DeleteProduct(product);
				LoadData();
			}
		}
	}
}