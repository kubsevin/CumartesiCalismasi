using Cumarteside.Classes;
using Cumarteside.Entities;
using Cumarteside.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OHMConvertAndClone;
namespace Cumarteside.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
           
            //var model = ctx.Users.Select(user => user.TransformTo<UserUpdateAndListModel>());

            List<UserUpdateAndListModel> model = new List<UserUpdateAndListModel>();
            foreach (User user in DbFactory.UserCrud.Records)
            {
                model.Add(user.TransformTo<UserUpdateAndListModel>());
            }

            return View(model);


            ////bu işlem 1 ve 2 yi yapıyor.
            //var model = ctx.Users.Select(x => x.FirstName + " " +x.LastName);

            ////1.
            //List<string> model1 = new List<string>();
            //foreach (var item in ctx.Users)
            //{
            //    model1.Add(GetFullName(item));
            //}

        }
        ////2.
        //public string GetFullName(User user)
        //{
        //    return user.FirstName + " " + user.LastName;
        //}

        // GET: User/Details/5
        public ActionResult Details(string id)
        {
           
            var user = DbFactory.UserCrud.Find(id);
            return PartialView(user.TransformTo<UserUpdateAndListModel>());
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserCreateModel collection)
        {
            try
            {
     
                //User user = new User();
                //user.FirstName = collection.FirstName;
                //user.LastName = collection.LastName;
                //user.Password = collection.Password;
                //user.UserName = collection.UserName;
                //user.BirthDate = collection.BirthDate;
                User user = collection.TransformTo<User>();

                DbFactory.UserCrud.Insert(user);

                //warning,error,success,info
                TempData["swal"] = "swal('Oluşturuldu','Yeni bir kullanıcı eklendi','success')";

                return RedirectToAction("Index");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {
            
            var user = DbFactory.UserCrud.Find(id);
            return PartialView(user.TransformTo<UserUpdateAndListModel>());
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, UserUpdateAndListModel collection)
        {
            try
            {
                // TODO: Add update logic here
                DbFactory.UserCrud.Update(id, collection.TransformTo<User>());
                return RedirectToAction("Index");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.UserCrud.Delete(id);
            return RedirectToAction("Index","User");
        }

    }
}
