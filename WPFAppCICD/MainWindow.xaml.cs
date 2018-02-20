using SideProject;
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

namespace WPFAppCICD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel
    {
        private SideProjectObject SPObject = new SideProjectObject();

        public MainWindowViewModel()
        {
            this.WPFAppCICDAssemblyVersionLabel = typeof(MainWindow).Assembly.GetName().Version.ToString();
            this.SideProjectObjectAssemblyVersionLabel = SPObject.AssemblyVersionLabel;
        }

        public string WPFAppCICDAssemblyVersionLabel { get; set; }        

        public string SideProjectObjectAssemblyVersionLabel { get; set; }
    }
}
