using System;
using System.Collections.Generic;
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

namespace GpxNodeLijster
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

        string InputPath;

        private void DeletButton_Click(object sender, RoutedEventArgs e)
        { 
            
        }

        private void InputConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            InputPath = InputBox.Text;

            string[] files = System.IO.Directory.GetFiles(InputPath, "*.gpx");

            foreach (var file in files)
            {
                ListBox_files.Items.Add(file);
            }


        }

        private void FileRenameButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
