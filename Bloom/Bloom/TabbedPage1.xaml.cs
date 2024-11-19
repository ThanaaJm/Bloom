using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;
using static Xamarin.Essentials.Permissions;

namespace Bloom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        private SQLiteConnection conn;

        public TabbedPage1 ()
        {
            InitializeComponent();
        }

        private async void guides(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new guides());
        }

            private async void development(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new development());
        }

        private async void activies(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activies());
        }

        private async void teeth(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new teeth());
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<User>();

            string name = txtName.Text;
            string phoneString = txtPhone.Text;
            int phone = 0;
            if (!string.IsNullOrEmpty(phoneString) && int.TryParse(phoneString, out int parsedPhone))
            {
                phone = parsedPhone;
            }
            string email = txtEmail.Text;

            var maxpk = conn.Table<User>().OrderByDescending(c => c.id).FirstOrDefault();
            User user = new User()
            {
                id = (maxpk == null ? 1 : maxpk.id + 1),
                name = name,
                phone = phone,
                email = email
            };
            conn.Insert(user);
            await DisplayAlert(null, user.name + " saved with ID = " + user.id, "ok");

        }
        private async void get_Clicked(object sender, EventArgs e)
        {
            string admin = adminEntry.Text;
            string password = passwordEntry.Text;

            if (admin == "admin" && password == "123")
            {
                await Navigation.PushAsync(new getAllUsers());
            }else
            {
                await DisplayAlert(null, " wrong please check your username/passwords", "ok");
            }

        }
    }
}