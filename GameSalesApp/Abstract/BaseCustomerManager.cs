using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Abstract
{
    public abstract class BaseUserManager: IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "sisteme eklendi.");
        }

        public virtual void Add2(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "sisteme eklendi.");

        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "silindi.");
        }

        public virtual void Save(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " " + "Müşteri veri tabanına kaydedildi");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Müşteri: " + user.FirstName + " " + user.LastName + " " + "güncellendi.");
        }
    }
}
