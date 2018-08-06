using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFinanceApp.Domain
{
    public class Person
    {
        public Person()
        {
            Agreements = new List<Agreement>();
        }
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(300)]
        public string FirstName { get; set; }
        [MaxLength(300)]
        public string SecondName { get; set; }
        [MaxLength(300)]
        public string Surname { get; set; }
        [MaxLength(300)]
        public string NationalIdentificationNumber { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        [MaxLength(300)]
        public string PhoneNumber { get; set; }
        [MaxLength(300)]
        public string PhoneNumber2 { get; set; }
        public virtual List<Agreement> Agreements { get; set; }
    }
}
