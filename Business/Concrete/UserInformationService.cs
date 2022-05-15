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
    public class UserInformationService : IUserInformationService
    {
        private readonly AppDbContext db;
        UserInformationRepository _userInformationRepository;
        public UserInformationService()
        {
            _userInformationRepository = new UserInformationRepository(db);
        }
        public bool Add(UserInformation entity)
        {
            return _userInformationRepository.Add(entity);
        }

        public bool Delete(UserInformation entity)
        {
            return _userInformationRepository.Delete(entity);
        }

        public IEnumerable<UserInformation> GetAll()
        {
            return _userInformationRepository.GetAll();
        }

        public IEnumerable<UserInformation> GetAllWithArticles()
        {
            return _userInformationRepository.GetAllWithArticles();
        }

        public UserInformation GetById(int id)
        {
            return _userInformationRepository.GetById(id);
        }

        public bool Update(UserInformation entity)
        {
            return _userInformationRepository.Update(entity);
        }
    }
}
