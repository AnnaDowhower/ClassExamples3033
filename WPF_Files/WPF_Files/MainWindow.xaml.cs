using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace WPF_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFindFile_Click(object sender, RoutedEventArgs e)
        {
            //google c#.net corefile class > microsoft top search > use the write/read all lines/text examples

            string file = txtFilePath.Text;

            if (File.Exists(file) == false)
            {
                MessageBox.Show("Invalid file");
                txtFilePath.Clear();
                return;
            }

            string[] contents = File.ReadAllLines(file);

            for (int i = 1; i < contents.Length; i++)
            {
                string line = contents[i];
                lstLines.Items.Add(line);
            }
        }
    }
}
