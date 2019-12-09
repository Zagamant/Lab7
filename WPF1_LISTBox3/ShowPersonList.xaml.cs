using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF1_ListBox3
{
    /// <summary>
    /// Interaction logic for SHOWPerson_List.xaml
    /// </summary>
    public partial class ShowPersonList : Window
    {
        public ShowPersonList()
        {
            InitializeComponent();
            lbMain.ItemsSource = App.ListPerson;
        }

        private void onAddButtonClick(object sender, RoutedEventArgs e)
        {
            AddPerson addWindow = new AddPerson();
            addWindow.Show();
            Close();
        }

        private void onExitButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void onRemoveButtonClick(object sender, RoutedEventArgs e)
        {
            App.ListPerson.RemoveAt(lbMain.SelectedIndex);
            RemoveButton.IsEnabled = false;
            EditButton.IsEnabled = false;
        }

        private void onEditButtonClick(object sender, RoutedEventArgs e)
        {
            EditPerson editPerson = new EditPerson(App.ListPerson.At(lbMain.SelectedIndex));
            editPerson.Show();
            Close();
        }


        private void onSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lbMain.SelectedItem != null && (lbMain.SelectedItem.ToString() != ""))
            {
                RemoveButton.IsEnabled = true;
                EditButton.IsEnabled = true;
            }
        }

        private void SearchByText_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbMain.ItemsSource = App.ListPerson.GetElementsBySubstr(SearchByText.Text);
        }

        private void WorkExperience_TextChanged(object sender, TextChangedEventArgs e)
        {
            double salary = 0;
            try
            {
                salary = double.Parse(WorkExperience.Text);
            } catch (FormatException exep)
            {
                Console.WriteLine(exep.Message);
            }

            lbMain.ItemsSource = App.ListPerson.GetElementsWithSalaryMoreThan(salary);
        }

        private void onShowJuniorsButtonClick(object sender, RoutedEventArgs e)
        {
            SearchByText.Text = ""; 
            WorkExperience.Text = "";
            lbMain.ItemsSource = App.ListPerson.GetElementsWithExperienceLowerThan(2);
        }
    }
}
