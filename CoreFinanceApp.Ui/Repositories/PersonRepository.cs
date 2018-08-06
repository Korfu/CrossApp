using CoreFinanceApp.Domain;
using CoreFinanceApp.Data;
using System.Collections.Generic;

namespace CoreFinanceApp.Ui
    {
    public class PersonRepository
    {
        public int PushPeopleToDb(Person personObject)
        {

            using (var context = new CrossFinanceContext())
            {
                context.People.Add(personObject);
                context.SaveChanges();
            }
            return personObject.Id;
        }
    }
}
