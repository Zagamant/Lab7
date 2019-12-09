using System.Windows;
using task1ListBoxPerson.Services;

namespace WPF1_ListBox3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ListPerson ListPerson;

        protected override void OnStartup(StartupEventArgs e)
        {
            ListPerson = new ListPerson();
            base.OnStartup(e);
        }

    }
}
