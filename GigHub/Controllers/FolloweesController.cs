﻿using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    [Authorize]
    public class FolloweesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FolloweesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Followers
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var followees = _context.Followings
                .Where(g => g.FollowerId == userId)
                .Select(g => g.Followee)
                .ToList();

            return View(followees);
        }
    }
}