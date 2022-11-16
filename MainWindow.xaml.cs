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

namespace GTO_Rassokhin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person johnSmith = new Person();

            johnSmith.JobID = "Бег на 2000м(мин, с)";
            johnSmith.JobData = "0";
            johnSmith.UserID = "0";
            johnSmith.IssueSubject = "0";
            johnSmith.Screen = "12";
            johnSmith.Furtherlnformation = "11.2";
            johnSmith.JobStatus = "9.5";

            DataGridXAML.Items.Add(johnSmith);

            Person johnSmith2 = new Person();

            johnSmith2.JobID = "Бег на 3000м(мин, с)";
            johnSmith2.JobData = "15";
            johnSmith2.UserID = "14.3";
            johnSmith2.IssueSubject = "12.4";
            johnSmith2.Screen = "0";
            johnSmith2.Furtherlnformation = "0";
            johnSmith2.JobStatus = "0";

            DataGridXAML.Items.Add(johnSmith2);
        }
        public class Person
        {
            public string JobID { get; set; }
            public string JobData { get; set; }
            public string UserID { get; set; }
            public string IssueSubject { get; set; }
            public string Screen { get; set; }
            public string Furtherlnformation { get; set; }
            public string JobStatus { get; set; }


        }


        private void Y_Itog_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(Y_Text.Text);
            if (x <= 12.4)
            {
                MessageBox.Show("Золото");
            }
            else if (x <= 14.3)
            {
                MessageBox.Show("Серебро");
            }
            else if (x <= 15)
            {
                MessageBox.Show("Бронза");
            }
        }

        private void D_Itog_Click(object sender, RoutedEventArgs e)
        {
            double y = double.Parse(D_Text.Text);
            if (y <= 9.5)
            {
                MessageBox.Show("Золото");
            }
            else if (y <= 11.2)
            {
                MessageBox.Show("Серебро");
            }
            else if (y <= 12)
            {
                MessageBox.Show("Бронза");
            }
        }
    }

 }

