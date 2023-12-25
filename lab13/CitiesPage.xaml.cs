// Изменения в PassengersPage.xaml.cs
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassengersPage : ContentPage
    {
        public PassengersPage()
        {
            InitializeComponent();
        }

        private void SavePassenger(object sender, EventArgs e)
        {
            var city = (City)BindingContext;
            if (!String.IsNullOrEmpty(city.CityName))
            {
                using (AppDbContext db = new AppDbContext())
                {
                    if (city.CityId == 0)
                        db.Cities.Add(city);
                    else
                    {
                        db.Cities.Update(city);
                    }
                    db.SaveChanges();
                }
            }
            this.Navigation.PopAsync();
        }

        private void DeletePassenger(object sender, EventArgs e)
        {
            var city = (City)BindingContext;
            using (AppDbContext db = new AppDbContext())
            {
                db.Cities.Remove(city);
                db.SaveChanges();
            }
            this.Navigation.PopAsync();
        }
    }
}
