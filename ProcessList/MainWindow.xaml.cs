using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProcessList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var gridView = new GridView();
            ListView.View = gridView;

            gridView.Columns.Add(new GridViewColumn { Header = "PID", DisplayMemberBinding = new Binding("Id"), Width = 100 });
            gridView.Columns.Add(new GridViewColumn { Header = "Process name", DisplayMemberBinding = new Binding("ProcessName"), Width = 200 });

            ListView.ItemsSource = GetProcesses();
        }

        public List<Process> GetProcesses()
        {
            return Process.GetProcesses().ToList();
        }
    }
}
