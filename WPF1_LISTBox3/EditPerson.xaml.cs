using System;
using System.Globalization;
using System.Windows;
using task1ListBoxPerson;

namespace WPF1_ListBox3
{
    /// <summary>
    /// Interaction logic for EDITPerson.xaml
    /// </summary>
    public partial class EditPerson : Window
    {
        private readonly PersonEntity _person;

        public EditPerson(PersonEntity p)
        {
            _person = p;
            InitializeComponent();
            LastName.Text = _person.LastName;
            FirstName.Text = _person.FirstName;
            Salary.Text = _person.Salary.ToString(CultureInfo.InvariantCulture);
            WorkExperience.Text = _person.WorkExperience.ToString();
        }

        private void onSaveButtonClick(object sender, RoutedEventArgs e)
        {
            _person.LastName = LastName.Text;
            _person.FirstName = FirstName.Text;


            double salary = 500;
            try
            {
                salary = double.Parse(Salary.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            _person.Salary = salary;

            var workExperience = 0;
            try
            {
                workExperience = int.Parse(WorkExperience.Text);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            _person.WorkExperience = workExperience;

            var showWindow = new ShowPersonList();
            showWindow.Show();
            Close();
        }
    }
}
