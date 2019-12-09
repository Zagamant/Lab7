using System.Windows;

namespace WPF1_ListBox3
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

        private void onAddButtonClick(object sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
            Close();
        }

        private void onShowButtonClick(object sender, RoutedEventArgs e)
        {
            ShowPersonList showPersonList = new ShowPersonList();
            showPersonList.Show();
            Close();
        }
    }
}
