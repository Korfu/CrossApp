using CoreFinance.Domain;
using System.Collections.Generic;

namespace CoreFinanceApp.Repositories
{
    public interface IPersonRepository
    {
        void Add(Person person);
        IEnumerable<Person> GetAll();
    }

    public class PersonRepository : IPersonRepository
    {
        private static List<Person> _allPeople = new List<Person>();

        public void Add(Person person)
        {
            _allPeople.Add(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return _allPeople;
        }

    }
}
