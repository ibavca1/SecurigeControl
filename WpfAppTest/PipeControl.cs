using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppTest
{
    public class PipeControl : ItemsControl
    {
        public ObservableCollection<Checker> Checkers { get; set; }
        static PipeControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PipeControl), new FrameworkPropertyMetadata(typeof(PipeControl)));
        }
        public PipeControl()
        {
            Checkers = new ObservableCollection<Checker>
            {
                new Checker(),
                new Checker(),
                new Checker(),
                new Checker(),
                new Checker()
            };
            ItemsSource = Checkers;
        }
    }

    public class Checker
    {
        public int Id { get; set; }
    }
}
