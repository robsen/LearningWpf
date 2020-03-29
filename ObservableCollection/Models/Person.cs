
using System;

namespace ObservableCollection.Models
{
    // BusinessModel!
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = NextFreeId;
        }

        private static int _nextFreeId = 1;
        public int NextFreeId
        {
            get
            {
                return _nextFreeId++;
            }
            private set
            {
                _nextFreeId = value;
            }
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        internal bool IsValid()
        {
            return (string.IsNullOrWhiteSpace(FirstName) == false
                && string.IsNullOrWhiteSpace(LastName) == false)
                ? true : false;
        }
    }
}
