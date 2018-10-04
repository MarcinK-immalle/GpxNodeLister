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
                XmlDocument xmldoc = new XmlDocument();
                XmlNodeList xmlnode;

                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("gpx");

                for (int i = 0; i < xmlnode.Count; i++)
                {
                    nodeStr = string.Format("{0}", xmlnode[i].ChildNodes.Item(6).InnerText);
                }

                string fileNodeName = file + nodeStr;

                ListBox_files.Items.Add(file);
            }
        }

        private void FileRenameButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
