using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumarteside.Entities
{
    //public class DbObject
    //{
    //    public string Id { get; set; }
    //    public DateTime CreationDate { get; set; }
    //    public string Creator { get; set; }
    //    public DateTime UpdateDate { get; set; }
    //    public string Updater { get; set; }
    //    public DbObject()
    //    {
    //        Id = Guid.NewGuid().ToString();
    //        CreationDate = DateTime.Now;

    //    }
    //}
    public class User : DbObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }


    }
}