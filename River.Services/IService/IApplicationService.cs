﻿using River.Data.Models.Domain;
using River.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Services.IService
{
    public interface IApplicationService
    {
        public bool AddApplication(Application application, String userId);

    }
}
