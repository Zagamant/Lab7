using System;
using System.Windows;
using task1ListBoxPerson;

namespace WPF1_ListBox3
{
    /// <summary>
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        public void onShowAllButtonClick(object sender, RoutedEventArgs e)
        {
            var person = new PersonEntity
            {
                FirstName = FirstName.Text, 
                LastName = LastName.Text
            };

            double salary = 500;
            try
            {
                salary = double.Parse(Salary.Text);
            }
            catch (FormatException exep)
            {
                Console.WriteLine(exep.Message);
            }
            person.Salary = salary;

            int workExperience = 0;
            try
            {
                workExperience = Int32.Parse(WorkExperience.Text);
            }
            catch (FormatException exep)
            {
                Console.WriteLine(exep.Message);
            }
            person.WorkExperience = workExperience;

            App.ListPerson.Add(person);

            ShowPersonList showWindow = new ShowPersonList();
            showWindow.Show();
            Close();
        }
    }
}
