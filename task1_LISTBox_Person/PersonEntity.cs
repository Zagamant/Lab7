namespace task1ListBoxPerson
{
    public class PersonEntity
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public double Salary { set; get; }
        public int WorkExperience { set; get; }

        public override string ToString()
        {
            return $"LastName = {LastName}, FirstName = {FirstName}\n";
        }
    }
}
