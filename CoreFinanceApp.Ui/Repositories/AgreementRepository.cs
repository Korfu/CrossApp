using CoreFinanceApp.Data;
using CoreFinanceApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFinanceApp.Ui
{
    public class AgreementRepository
    {
        public void PushAgreementsToDb(Agreement agreementObject)
        {

            using (var context = new CrossFinanceContext())
            {
                context.Agreements.Add(agreementObject);
                context.SaveChanges();
            }
        }

    }
}