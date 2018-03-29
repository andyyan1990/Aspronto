using System;
using System.Collections.Generic;
using Aspronto.Logic;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Aspronto
{
    public partial class DashboardPage : ContentPage
    {
        Geocoder geoCoder;
        //String currentLocation = string.Empty;

        public DashboardPage()
        {
            InitializeComponent();
            Title = "Home";
            geoCoder = new Geocoder();
            webView.Source = "https://cdnres.willyweather.com.au/widget/loadView.html?id=45970";
            webView.WidthRequest = Application.Current.MainPage.Width;



        }

        protected override async void OnAppearing()
		{
            base.OnAppearing();

            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync();
            //try{
            //    var cO = await COLogic.GetCO(position.Latitude, position.Longitude);
            //    CO.Text = cO.ToArray()[0].Value.ToString();
            //}catch(System.NullReferenceException){
            //    CO.Text = "0";
            //}


            //try{
            //    var o3 = await O3Logic.GetO3(position.Latitude, position.Longitude);
            //}catch(Exception e){
            //    O3.Text = "0";
            //    Console.WriteLine(e);
            //}

            //try{
            //    var nO2 = await NO2Logic.GetNO2(position.Latitude, position.Longitude);
            //}catch(NullReferenceException){
            //    NO2.Text = "0";
            //}

            //try{
            //    var sO2 = await SO2Logic.GetSO2(position.Latitude, position.Longitude);
            //}catch(System.NullReferenceException){
            //    SO2.Text = "0";
            //}


            //if(cO.Equals(null) || cO.Count == 0)
            //{
            //    CO.Text = "0";

            //}else{
                
            //    CO.Text = cO.ToArray()[0].Value.ToString();
            //}

            //if (o3.Equals(null) || o3.Count == 0)
            //{
            //    O3.Text = "0";
            //}
            //else
            //{
            //    O3.Text = o3.ToArray()[0].Value.ToString();
            //}

            //if (nO2.Equals(null) || nO2.Count == 0)
            //{
            //    NO2.Text = "0";
            //}
            //else
            //{
            //    NO2.Text = nO2.ToArray()[0].Value.ToString();
            //}

            //if (sO2.Equals(null) || sO2.Count == 0)
            //{
            //    SO2.Text = "0";
            //}
            //else
            //{
            //    SO2.Text = sO2.ToArray()[0].Value.ToString();
            //}

            //var geoPosition = new Position(position.Latitude, position.Longitude);

            //var rawAddress = await geoCoder.GetAddressesForPositionAsync(geoPosition);

            //foreach (var address in rawAddress)
                //currentLocation.Text += address + "\n";
		}
	}
}
