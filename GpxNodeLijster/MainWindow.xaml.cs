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
using System.Xml;
using System.Xml.Linq;

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
        string nodeStr;

        private void DeletButton_Click(object sender, RoutedEventArgs e)
        { 
            
        }

        private void InputConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            InputPath = InputBox.Text;

            string[] files = System.IO.Directory.GetFiles(InputPath, "*.gpx");
            
            foreach (var file in files)
            {
                FileStream fs = new FileStream(InputPath, FileMode.Open, FileAccess.Read);

                var xdoc = XDocument.Load(fs);
                var units = from u in xdoc.Descendants("gpx")
                            select new
                            {
                                urlname = (string)u.Element("urlname")
                                //Id = (int)u.Element("id"),
                                //Name = (string)u.Element("name")
                            };

                foreach (var unit in units)
                {
                    // thanks God for IntelliSense!
                    //MessageBox.Show(String.Format("ID:{0}\r\nName:{1}", unit.Id, unit.Name));
                    MessageBox.Show(string.Format("{0}", unit.urlname));
                }
                ListBox_files.Items.Add(file);
            }
        }

        private void FileRenameButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
