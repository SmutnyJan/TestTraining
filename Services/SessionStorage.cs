using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Helpers;
using WebApplication1.InputModel;

namespace WebApplication1.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        private const string key = "USER";
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        public void setUser(UserSubscription user)
        {
            _session.Set<UserSubscription>(key, user);
        }
        public UserSubscription getUser()
        {
            return _session.Get<UserSubscription>(key);
        }
    }
}
