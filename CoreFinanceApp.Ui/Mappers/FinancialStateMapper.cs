using CoreFinanceApp.Domain;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace CoreFinanceApp.Ui.Mappers
{
    public class FinancialStateMapper
    {
        public FinancialState MapFinancialState(Worksheet worksheet, int i, Dictionary<string, int> columnNamesWithIndex)
        {
            var outstandingLiabilitesIndex = columnNamesWithIndex["Kapital"];
            decimal outstandingLiabilites = (decimal)worksheet.Cells[outstandingLiabilitesIndex][i].Value;


            var interestsIndex = columnNamesWithIndex["odsetki"];
            decimal interests = (decimal)worksheet.Cells[interestsIndex][i].Value;

            var penaltyInterestsIndex = columnNamesWithIndex["odsetki Karne"];
            decimal penaltyInterests = (decimal)worksheet.Cells[penaltyInterestsIndex][i].Value;

            var feesIndex = columnNamesWithIndex["opłaty"];
            decimal fees = (decimal)worksheet.Cells[feesIndex][i].Value;

            var courtFeesIndex = columnNamesWithIndex["koszty sadowe"];
            decimal courtFees = (decimal)worksheet.Cells[courtFeesIndex][i].Value;

            var representationCourtFeesIndex = columnNamesWithIndex["koszty zastepstwa sadowego"];
            decimal representationCourtFees = (decimal)worksheet.Cells[representationCourtFeesIndex][i].Value;

            var vindicationcostsIndex = columnNamesWithIndex["koszty egzekucji"];
            decimal vindicationcosts = (decimal)worksheet.Cells[vindicationcostsIndex][i].Value;

            var representationVindicationcostsIndex = columnNamesWithIndex["koszty zastepstwa egzekucyjnego"];
            decimal representationVindicationcosts = (decimal)worksheet.Cells[representationVindicationcostsIndex][i].Value;

            FinancialState newFinancialState = new FinancialState
            {
                OutstandingLiabilities = outstandingLiabilites,
                Interests = interests,
                PenaltyInterests = penaltyInterests,
                Fees = fees,
                CourtFees =courtFees,
                RepresentationCourtFees = representationCourtFees, 
                VindicationCosts = vindicationcosts,
                RepresentationVindicationCosts = representationVindicationcosts
            };
            return newFinancialState;
        }
    }
}