using System;

namespace LISTBox_Person
{
    public class PersonEntity
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }

        public override string ToString()
        {
            return String.Format("LastName = {0}, FirstName = {1}\n", LastName, FirstName);
        }
    }
}
