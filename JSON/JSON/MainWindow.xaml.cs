using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSON
{
    //JSON formatter and validator

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient()) //using tab tab //for HttpClient you must make a using stmnt
            {
                string jsonData = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result; //.result means dont do anything until we get a result from user

                RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData);
                //This line pulls the info from the website and replaces the for loop that we would normally use to add itmes too the class by using the R&M class

                foreach (var item in api.results)
                {
                    cboCharacters.Items.Add(item);
                }



            }
        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character selected = (Character)cboCharacters.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(selected.image));
            lblName.Content = selected.name;


        }



    }
}
