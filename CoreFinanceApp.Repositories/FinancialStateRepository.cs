using CoreFinance.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFinanceApp.Repositories
{   
    public interface IFinancialStateRepository
    {
        void Add(FinancialState financialState);
        IEnumerable<FinancialState> GetAll();
    }

    class FinancialStateRepository : IFinancialStateRepository
    {
        private static List<FinancialState> _allFinancialStates = new List<FinancialState>();

        public  void    Add(FinancialState financialstate)
        {
            _allFinancialStates.Add(financialstate);
        }
        public IEnumerable<FinancialState> GetAll()
        {
            return _allFinancialStates;
        }
    }
}
