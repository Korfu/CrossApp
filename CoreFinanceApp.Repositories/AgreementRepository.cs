using CoreFinance.Domain;
using System.Collections.Generic;

namespace CoreFinanceApp.Repositories
{
    public interface IAgreementRepository
    {
        void Add(Agreement agreement);
        IEnumerable<Agreement> GetAll();
    }

    public class AgreementRepository : IAgreementRepository
    {
        private static List<Agreement> _allAgreements = new List<Agreement>();

        public void Add(Agreement agreement)
        {
            _allAgreements.Add(agreement);
        }

        public IEnumerable<Agreement> GetAll()
        {
            return _allAgreements;
        }

    }

}

