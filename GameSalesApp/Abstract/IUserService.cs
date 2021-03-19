using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}
