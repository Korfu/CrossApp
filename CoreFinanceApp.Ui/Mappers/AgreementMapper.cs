using CoreFinanceApp.Domain;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFinanceApp.Ui.Mappers
{
    public class AgreementMapper
    {
        public Agreement MapAgreement(Worksheet worksheet, int i, Dictionary<string, int> columnNamesWithIndex, int personId, int financialStateID)
        {
            var numberIndex = columnNamesWithIndex["nr_umowy"];
            var number = worksheet.Cells[numberIndex][i].Value?.ToString();

            Agreement newAgreement = new Agreement
            {
                Number = number,
                PersonId = personId,
                FinancialStateId = financialStateID
            };
            return newAgreement;
        }
    }
}