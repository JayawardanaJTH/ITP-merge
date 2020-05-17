﻿using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Staff_Management1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(User userModel)
        {
            using (DBmodel db = new DBmodel())
            {
                string username = userModel.Username;
                string password = userModel.Password;

                var teacherDetails = db.Teachers.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                var managerDetails = db.Offices.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                var cleanerDetails = db.Cleaners.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                var studentDetails = db.StudentTBs.Where(x => x.username == username && x.password == password).FirstOrDefault();

                if (teacherDetails != null)
                {
                    Session["UserID"] = teacherDetails.UserID;
                    return RedirectToAction("Index", "Home1");
                }
                else if (managerDetails != null)
                {
                    Session["UserID"] = managerDetails.UserID;
                    return RedirectToAction("Index", "AdminPanel");
                }
                else if (cleanerDetails != null)
                {
                    Session["UserID"] = cleanerDetails.UserID;
                    return RedirectToAction("Index", "Home1");
                }
                else if(studentDetails != null)
                {
                    Session["sid"] = studentDetails.sid;
                    return RedirectToAction("Index", "Homepage");
                }
                else if (username == "Admin" && password == "admin")
                {
                    return RedirectToAction("Index", "AdminPanel");

                }
                else
                {
                    userModel.LoginErrorMessage = "wrong username or password";
                    return View("Loginpage", userModel);

                }
            }
        }

        public ActionResult RegisterChoose()
        {
            return View();
        }
    }
}