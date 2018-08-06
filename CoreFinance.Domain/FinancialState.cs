using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreFinanceApp.Domain
{
    public class FinancialState
    {
        public FinancialState()
        {
            Agreements = new List<Agreement>();
        }
        [MaxLength(11)]
        public int Id { get; set; }
        public decimal? OutstandingLiabilities { get; set; }
        public decimal? Interests { get; set; }
        public decimal? PenaltyInterests { get; set; }
        public decimal? Fees { get; set; }
        public decimal? CourtFees { get; set; }
        public decimal? RepresentationCourtFees { get; set; }
        public decimal? VindicationCosts { get; set; }
        public decimal? RepresentationVindicationCosts { get; set; }
        public virtual List<Agreement> Agreements { get; set; }
        //public int AgreementId { get; set; }
    }
}
