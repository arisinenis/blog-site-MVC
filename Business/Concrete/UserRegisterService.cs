using Business.Abstract;
using Core.Concrete;
using DataAccess.Context;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserRegisterService : IBaseService<UserRegister>
    {
        private readonly AppDbContext db;
        UserRegisterRepository _userRegistersRepository;
        public UserRegisterService()
        {
            _userRegistersRepository = new UserRegisterRepository(db);
        }

        public bool Add(UserRegister entity)
        {
            return _userRegistersRepository.Add(entity);
        }

        public bool Delete(UserRegister entity)
        {
            return _userRegistersRepository.Delete(entity);
        }

        public IEnumerable<UserRegister> GetAll()
        {
            return _userRegistersRepository.GetAll();
        }

        public UserRegister GetById(int id)
        {
            return _userRegistersRepository.GetById(id);
        }

        public bool Update(UserRegister entity)
        {
            return _userRegistersRepository.Update(entity);
        }
    }
}
