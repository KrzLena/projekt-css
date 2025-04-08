using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace zadanie
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double celcjusz = double.Parse(celc.Text);
            
                if ( celcjusz < -273.15)
                {
                    celc.Foreground = Brushes.White;
                    celc.Background = Brushes.Red;
                    kelw.Text = " ";
                }
                else
                {
                    double kalwin = celcjusz + 273.15;
                    kelw.Text = kalwin.ToString()+ "°";
                    celc.Foreground = Brushes.Black;
                    celc.Background = Brushes.White;
                }
        }
    }
}