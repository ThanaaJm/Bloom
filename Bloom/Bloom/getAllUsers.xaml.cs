using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bloom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class getAllUsers : ContentPage
    {
        private SQLiteConnection conn;
        User user = new User();

        public getAllUsers()
        {
            InitializeComponent();

            base.OnAppearing();
            conn = DependencyService.Get<ISQLite>().GetConnection();

            listview.ItemsSource = conn.Table<User>().OrderBy(x => x.name).ToList();
        }
        private async void update_Clicked(object sender, EventArgs e)
        {
            User u = new User()
            {
                id = Convert.ToInt32(idEntry.Text),
                name = nameEntry.Text,
                phone = Convert.ToInt32(phoneEntry.Text),
                email = emailEntry.Text,
            };

            conn.Update(u);
            listview.ItemsSource = conn.Table<User>().OrderBy(x => x.name).ToList();
        }
        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            user = (User)e.SelectedItem;
            idEntry.Text = user.id.ToString();
            nameEntry.Text = user.name;
            phoneEntry.Text = user.phone.ToString();
            emailEntry.Text = user.email;

            nameEntry.IsVisible = true;
            phoneEntry.IsVisible = true;
            emailEntry.IsVisible = true;

            update.IsVisible = true;
            Delete.IsVisible = true;

        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            User u = new User()
            { id = Convert.ToInt32(idEntry.Text) };
            conn.Delete(u);
            listview.ItemsSource = conn.Table<User>().OrderBy(x => x.name).ToList();
        }
    }
}
