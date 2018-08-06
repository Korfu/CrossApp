using CoreFinanceApp.Data;
using CoreFinanceApp.Domain;
using System.Collections.Generic;

namespace CoreFinanceApp.Ui
{
    public class FinancialStateRepository
    {
        public int PushFinancialStatesToDb(FinancialState financialStateObject)
        {
            using (var context = new CrossFinanceContext())
            {
                context.FinancialStates.Add(financialStateObject);
                context.SaveChanges();
            }
            return financialStateObject.Id;
        }
    }
}
