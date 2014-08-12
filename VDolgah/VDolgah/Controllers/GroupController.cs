﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VDolgah.Models;

namespace VDolgah.Controllers
{
    public class GroupController : Controller
    {
        DbEntities db = DbEntities.Instance;

        public ActionResult Index(int group_id)
        {
            group group = db.groups.Where((x) => x.idgroups == group_id).First();
            return View(group);
        }

        public ActionResult Create()
        {
            group gr = new group();
            return View(gr);
        }

        [HttpPost]
        public ActionResult Create(group gr)
        {
            gr.creator = (Session["user"] as user).id;
            gr.users.Add(Session["user"] as user);
            DbEntities.Instance.groups.Add(gr);

            DbEntities.Instance.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
