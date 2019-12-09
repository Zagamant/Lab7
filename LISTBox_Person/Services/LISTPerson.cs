using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LISTBox_Person.Services
{
    class LISTPerson : IEnumerable
    {
        private List<PersonEntity> listPerson;

        public LISTPerson()
        {
            Initialize();
        }

        private void Initialize()
        {
            listPerson = new List<PersonEntity>
            {
                new PersonEntity() { LastName = "Иванов", FirstName = "Иван"},
                new PersonEntity() { LastName = "Сидоров", FirstName = "Сидор"},
                new PersonEntity() { LastName = "Петров", FirstName = "Петр"},
            };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var person in listPerson)
                yield return person;
        }
    }
}
