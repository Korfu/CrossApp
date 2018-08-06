using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreFinanceApp.Domain
{
    public class Address
    {
        public Address()
        {
            People = new List<Person>();
        }
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(300)]
        public string StreetName { get; set; }
        [MaxLength(300)]
        public string StreetNumber { get; set; }
        [MaxLength(300)]
        public string FlatNumber { get; set; }
        [MaxLength(300)]
        public string PostCode { get; set; }
        [MaxLength(300)]
        public string PostOfficeCity { get; set; }
        [MaxLength(300)]
        public string CorrespondenceStreetName { get; set; }
        [MaxLength(300)]
        public string CorrespondenceStreetNumber { get; set; }
        [MaxLength(300)]
        public string CorrespondenceFlatNumber { get; set; }
        [MaxLength(300)]
        public string CorrespondencePostCode { get; set; }
        [MaxLength(300)]
        public string CorrespondencePostOfficeCity { get; set; }
        [MaxLength(300)]
        public virtual List<Person> People { get; set; }

    }
}
