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
    public sealed partial class ListsPages : Page
    {

        string path;
        string path2;
        SQLite.Net.SQLiteConnection conn;
        SQLite.Net.SQLiteConnection conn2;

        public ListsPages()
        {
            this.InitializeComponent();

            // SQLite for TO-DO List
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
            "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            
            conn.CreateTable<List>();
            // Set ItemsSource to the sqlite data for ListView
            myList.ItemsSource = conn.Table<List>();

            // SQLite for Grocery List
            path2 = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
            "db.sqlite1");
            conn2 = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path2);


            conn.CreateTable<gList>();
            // Set ItemsSource to the sqlite data for ListView
            groceryList.ItemsSource = conn.Table<gList>();


        }

        // TODO List Buttons and Textboxs etc.
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }


        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            conn.DropTable<List>();
            //conn.Execute("DELETE FROM List WHERE Name = ?", Name);
            
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void appBarButton_Click(object sender, RoutedEventArgs e)
        {
            var s = conn.Insert(new List()
            {
                Name = textBox.Text,
                Date = textBox_Copy.Text
                
            });
            // Updates the ItemsSource for ListView
            myList.ItemsSource = conn.Table<List>();
        }

        // Grocery List Buttons and Textboxs etc.
        private void AddGrocery_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            var g = conn.Insert(new gList()
            {
                gName = AddGrocery.Text

            });
            // Updates the ItemsSource for ListView
            groceryList.ItemsSource = conn.Table<gList>();
        }
    }
    }
// End TODO List Buttons and Textboxs etc.

// Table for TO-DO List
public class List
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }

// Table for Grocery List
public class gList
{
    [PrimaryKey, AutoIncrement]
    public int gId { get; set; }
    public string gName { get; set; }
}