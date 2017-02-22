using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

        // Delete TO-DO List
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

        private async void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // If user enters text go into this if statement
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                string text = sender.Text;
                if (sender.Text.Length > 0)
                {
                    sender.ItemsSource = await Task<string[]>.Run(() => { return this.GetSuggestions(text); });
                }
                else
                {
                    sender.ItemsSource = new string[] { "No suggestions..." };
                }
            }
        }

        // Grocery Suggestions
        private string[] suggestions = new string[] { "asparagus", "apples", "avacado", "alfalfa", "acorn squash", "almond", "arugala", "artichoke", "applesauce", "asian noodles", "antelope", "ahi tuna", "albacore tuna", "Apple juice", "Avocado roll", "Bruscetta", "bacon", "black beans", "bagels", "baked beans", "BBQ", "bison", "barley", "beer", "bisque", "bluefish", "bread", "broccoli", "buritto", "babaganoosh", "Cabbage", "cake", "carrots", "carne asada", "celery", "cheese", "chicken", "catfish", "chips", "chocolate", "chowder", "clams", "coffee", "cookies", "corn", "cupcakes", "crab", "curry", "cereal", "chimichanga", "dates", "dips", "duck", "dumplings", "donuts", "eggs", "enchilada", "eggrolls", "English muffins", "edimame", "eel sushi", "fajita", "falafel", "fish  (might be too vague)", "franks", "fondu", "French toast", "French dip", "Garlic", "ginger", "gnocchi", "goose", "granola", "grapes", "green beans", "Guancamole", "gumbo", "grits", "Graham crackers", "ham", "halibut", "hamburger", "honey", "huenos rancheros", "hash browns", "hot dogs", "haiku roll", "hummus", "ice cream", "Irish stew", "Indian food", "Italian bread", "jambalaya", "jelly / jam", "jerky", "jalapeño", "kale", "kabobs", "ketchup", "kiwi", "kidney beans", "kingfish", "lobster", "Lamb", "Linguine", "Lasagna", "Meatballs", "Moose", "Milk", "Milkshake", "Noodles", "Ostrich", "Pizza", "Pepperoni", "Porter", "Pancakes", "Quesadilla", "Quiche", "Reuben", "Spinach", "Spaghetti", "Tater tots", "Toast", "Venison", "Waffles", "Wine", "Walnuts", "Yogurt", "Ziti", "Zucchini" };

        private string[] GetSuggestions(string text)
        {
            string[] result = null;

            result = suggestions.Where(x => x.Contains(text)).ToArray();

            return result;

        }

        // Done button adding to Grocery List
        private void done_Click(object sender, RoutedEventArgs e)
        {
            var g = conn.Insert(new gList()
            {
                gName = AddGrocery.Text

            });
            // Updates the ItemsSource for ListView
            groceryList.ItemsSource = conn.Table<gList>();
        }

        // Delete Grocery List
        private void groceryDelete_Click(object sender, RoutedEventArgs e)
        {
            conn.DropTable<gList>();
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