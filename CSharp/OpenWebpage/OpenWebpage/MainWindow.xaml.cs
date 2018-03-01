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
using System.IO;

namespace OpenWebpage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] filenames = Directory.GetFiles(@"C:\xampp\htdocs\worksandbox\athletes28Feb2018\AthleticsHtmlDisplay\data")
            .Select(System.IO.Path.GetFileName)
            .ToArray();

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                foreach (string file in filenames)
                {
                    if (file.Contains("_RESULT_LIST"))
                    {
                        Rfilename_cb.Items.Add(file.Substring(0,9));
                    }

                    if (file.Contains("_START_LIST"))
                    {
                        Sfilename_cb.Items.Add(file.Substring(0,9));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string RCode = $"?Code={ResultCode_tbox.Text}";
            string RLocation = "http://localhost/worksandbox/athletes28Feb2018/AthleticsHtmlDisplay/RESULTS_LIST.html" + RCode;

            try
            {   
                if(ResultCode_tbox.Text != String.Empty)
                {
                    System.Diagnostics.Process.Start(RLocation);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string SCode = $"?Code={StartCode_tbox.Text}";
            string SLocation = "http://localhost/worksandbox/athletes28Feb2018/AthleticsHtmlDisplay/START_LIST.html" + SCode;

            try
            {
                if(StartCode_tbox.Text != String.Empty)
                {
                    System.Diagnostics.Process.Start(SLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
