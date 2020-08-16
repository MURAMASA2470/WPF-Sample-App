using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF.Sample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Network> GridList;

        public Property Property = new Property();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Property;

            // Page Loaded
            this.Loaded += (s, e) =>
            {
                this.Property.GridList = new ObservableCollection<Network>();
                for (var i = 0; i < 5; i++)
                {
                    this.Property.GridList.Add(
                        new Network() { IP = $"192.168.1.{i * 10}", PORT = 8000, MAC = "AB:CD:EF:12:34" }
                    );
                }
            };

            // ExecButton Clicked
            this.btnExec.Click += (s, e) =>
            {
                this.Property.GridList.Add(
                    new Network() { IP = $"192.168.1.{1}", PORT = 8000, MAC = "AB:CD:EF:12:34" }
                );
            };


        }


        public class Network 
        {
            public string IP { get; set; }
            public int PORT { get; set; }
            public string MAC { get; set; }
        }
    }
}
