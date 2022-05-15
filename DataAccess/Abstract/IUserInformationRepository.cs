﻿using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    interface IUserInformationRepository : IBaseRepository<UserInformation>
    {
        IEnumerable<UserInformation> GetAllWithArticles();
    }
}
