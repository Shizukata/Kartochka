using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace Kartochka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Mails_1> mails_s = new List<Mails_1>();
            mails_s.Add(new Mails_1() { Kod = Kod.Text, Uch = Uch.Text, Kval = Kval.Text, Cpec = Cpec.Text });
            dgSimple.ItemsSource = mails_s;
        }
        public class Mails_1
        {
            public string Kod { get; set; }
            public string Uch { get; set; }
            public string Kval { get; set; }
            public string Cpec { get; set; }
        }
    }
}
