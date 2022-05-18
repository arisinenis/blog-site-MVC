using Business.Abstract;
using Core.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IUserRegisterRepository _userRegistersRepository;
        public UserRegisterService(IUserRegisterRepository _userRegistersRepository)
        {
            this._userRegistersRepository = _userRegistersRepository;
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
