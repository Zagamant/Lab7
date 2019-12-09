using System.Windows;
using task1ListBoxPerson.Services;

namespace WPF1_ListBox1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lbMain.ItemsSource = new ListPerson();
        }
    }
}
