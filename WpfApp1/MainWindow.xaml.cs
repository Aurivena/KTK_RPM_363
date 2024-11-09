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

namespace WpfApp1
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

        private int currentNum = 0;
        private int defaultNum = 0;

        private void removeNumber(object sender, MouseButtonEventArgs e)
        {
           if (listNumbers.SelectedItem != null) {
                listNumbers.Items.Remove(listNumbers.SelectedItem);
            }
        }

        private void appendNumber(object sender, MouseButtonEventArgs e)
        {
            listNumbers.Items.Add(currentNum);
            currentNum++;
        }

        private void clearListView(object sender, MouseButtonEventArgs e)
        {
            listNumbers.Items.Clear();
            listNumbers.Items.Add(defaultNum);
            currentNum = 1;
        }
    }
}