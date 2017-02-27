using Agenda.Common;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Agenda
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {

        string path;
        SQLite.Net.SQLiteConnection conn;

        public Register()
        {
            this.InitializeComponent();

            // SQLite for Username and Password List
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
            "db.registerDetails");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);


            conn.CreateTable<UserandPass>();
            // Set ItemsSource to the sqlite data for ListView
            //myList.ItemsSource = conn.Table<UserandPass>();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var p = conn.Insert(new UserandPass()
            {
                Name = txtUser.Text,
                Password = txtPassword.Text

            });
            // Updates the ItemsSource for ListView
            //myList.ItemsSource = conn.Table<UserandPass>();

            this.Frame.Navigate(typeof(MainPage));
        }

        // Table for Username and password List
        /*public class UserandPass
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }*/
    }
}
