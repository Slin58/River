﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using River.Data.Models.Domain;

namespace River.Services.IService
{
    public interface IUserService
    {
        IList<User> GetUsers();
        User GetUser(int id);
    }
}
