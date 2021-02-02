﻿using KPPDataManager.Library.DataAccess;
using KPPDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KPPDataManager.Controllers
{
    [Authorize]

    public class UserController : ApiController
    {
      
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId);
        }
    }
}
