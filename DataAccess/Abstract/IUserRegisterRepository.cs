using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRegisterRepository : IBaseRepository<UserRegister>
    {
        UserRegister GetByEmail(string email);
        UserRegister GetByEmailAndPassword(string email, string password);
    }
}
