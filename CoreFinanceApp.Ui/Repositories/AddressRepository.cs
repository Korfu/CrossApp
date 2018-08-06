using CoreFinanceApp.Domain;
using CoreFinanceApp.Data;

namespace CoreFinanceApp.Ui
{
    public class AddressRepository
    {
        public int PushAddressesToDb(Address addresObject){

        using (var context = new CrossFinanceContext())
            {
                context.Addresses.Add(addresObject);
                context.SaveChanges();
            }
            return addresObject.Id;
        }
    }
}
