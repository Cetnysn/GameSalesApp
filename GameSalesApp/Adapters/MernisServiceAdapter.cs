using GameSalesApp.Abstract;
using GameSalesApp.Entities;
using GameSalesApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Adapters
{
    public class MernisServiceAdapter: IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(user.NationalityId), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year, user.DateOfBirth.Month, user.DateOfBirth.Day);
        }
    }
}
