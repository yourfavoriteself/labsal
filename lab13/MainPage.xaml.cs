using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            using (AppDbContext db = new AppDbContext())
            {
                // Используйте правильное имя списка
                citiesList.ItemsSource = db.Cities.ToList();
            }
            base.OnAppearing();
        }

        // Обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            City selectedCity = (City)e.SelectedItem;
            PassengersPage passengersPage = new PassengersPage();
            passengersPage.BindingContext = selectedCity;
            await Navigation.PushAsync(passengersPage);
        }

        // Обработка нажатия кнопки добавления
        private async void CreateCity(object sender, EventArgs e)
        {
            City city = new City();
            PassengersPage passengersPage = new PassengersPage();
            passengersPage.BindingContext = city;
            await Navigation.PushAsync(passengersPage);
        }

        private class citiesList
        {
            public static List<City> ItemsSource { get; internal set; }
        }
    }
}
