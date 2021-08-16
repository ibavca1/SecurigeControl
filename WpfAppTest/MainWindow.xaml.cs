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

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Incidents = new ObservableCollection<Incident>
            {
                new Incident {Date = DateTime.Now, Desc = "Test1"},
                new Incident {Date = DateTime.Now, Desc = "Test2"},
                new Incident {Date = DateTime.Now, Desc = "Test3"},
                new Incident {Date = DateTime.Now, Desc = "Test4"},
                new Incident {Date = DateTime.Now, Desc = "Test5"},
                new Incident {Date = DateTime.Now, Desc = "Test6"},
                new Incident {Date = DateTime.Now, Desc = "Test7"},
                new Incident {Date = DateTime.Now, Desc = "Test8"}
            };
        }
        public ObservableCollection<Incident> Incidents { get; set; }
    }

    public class Incident
    {
        public DateTime Date { get; set; }
        public string Desc { get; set; }
    }
}
