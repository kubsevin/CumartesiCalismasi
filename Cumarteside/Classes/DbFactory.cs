using Cumarteside.Entities;
using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumarteside.Classes
{
    public static class DbFactory
    {
        private static CumartesideContext _db = new CumartesideContext();

        private static GenelCrud<User> _userCrud = null;
        public static GenelCrud<User> UserCrud
        {
            get
            {
                if (_userCrud==null)
                {
                    _userCrud = new GenelCrud<User>(_db, _db.Users);
                }
                return _userCrud;
            }
        }
    }
}