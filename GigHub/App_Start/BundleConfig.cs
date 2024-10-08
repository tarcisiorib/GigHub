﻿using System.Web;
using System.Web.Optimization;

namespace GigHub
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/app")
                .Include("~/Scripts/App/app.js",
                "~/Scripts/App/Services/attendanceService.js",
                "~/Scripts/App/Controllers/gigsController.js",
                "~/Scripts/App/Services/followingService.js",
                "~/Scripts/App/Controllers/gigDetailsController.js"));

            bundles.Add(new Bundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/underscore-umd-min.js",
                        "~/Scripts/moment.js",
                        "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
