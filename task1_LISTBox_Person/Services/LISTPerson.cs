using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace task1ListBoxPerson.Services
{
    public sealed class ListPerson : INotifyCollectionChanged, IEnumerable
    {
        private List<PersonEntity> _listPerson;

        public ListPerson()
        {
            Initialize();
        }

        private void Initialize()
        {
            _listPerson = new List<PersonEntity>
            {
                new PersonEntity { LastName = "Иванов", FirstName = "Иван", Salary= 1200, WorkExperience = 3 },
                new PersonEntity { LastName = "Сидоров", FirstName = "Сидор", Salary= 100, WorkExperience = 1 },
                new PersonEntity { LastName = "Петров", FirstName = "Петр", Salary= 500.67, WorkExperience = 0 },
            };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var person in _listPerson)
                yield return person;
        }

        public void Add(PersonEntity person)
        {
            _listPerson.Add(person);
            OnCollectionChanged(NotifyCollectionChangedAction.Reset);
        }

        public void RemoveAt(int index)
        {
            _listPerson.RemoveAt(index);
            OnCollectionChanged(NotifyCollectionChangedAction.Reset);
        }

        public PersonEntity At(int index)
        {
            return _listPerson[index];
        }

        public IEnumerable<PersonEntity> GetElementsBySubstr(String substr)
        {
            substr = substr.ToLowerInvariant();
            return from p in _listPerson
                   where p.LastName.ToLowerInvariant().Contains(substr) || p.FirstName.ToLowerInvariant().Contains(substr)
                   select p;
        }

        public IEnumerable<PersonEntity> GetElementsWithSalaryMoreThan(double minSalary)
        {
            return from p in _listPerson
                   where p.Salary > minSalary
                   orderby p.LastName
                   select p;
        }

        public IEnumerable<PersonEntity> GetElementsWithExperienceLowerThan(int years)
        {
            return from p in _listPerson
                   where p.WorkExperience < years
                   select p;
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void OnCollectionChanged(NotifyCollectionChangedAction action)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action));
        }

    }
}
