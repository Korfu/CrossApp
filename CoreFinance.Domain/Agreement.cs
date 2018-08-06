using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreFinanceApp.Domain
{
    public class Agreement
    {
        public Agreement()
        {
        }
        [MaxLength(11)]
        public int Id { get; set; }
        [MaxLength(3000)]
        public string Number { get; set; }
        public virtual Person Person { get; set; }
        [MaxLength(11)]
        public int PersonId { get; set; }
        public virtual FinancialState FinancialState { get; set; }
        [MaxLength(11)]
        public int FinancialStateId { get; set; }
    }
}
