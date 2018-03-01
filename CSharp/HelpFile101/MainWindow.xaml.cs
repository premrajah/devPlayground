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

namespace HelpFile101
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

        private void btn_helpIndex_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelpTableOfContents();
        }

        private void btn_showInformation_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelpTopic("Information");
        }

        private void btn_showAbout_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelpTopic("About");
        }
    }
}
