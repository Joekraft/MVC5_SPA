using System.Web;
using System.Web.Optimization;

namespace MVC5_SPA
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo.all").Include(
                      "~/Scripts/kendo/2020.3.915/kendo.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo.aspnetmvc").Include(
                      "~/Scripts/kendo/2020.3.915/kendo.aspnetmvc.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                      "~/Scripts/spa.js"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                      "~/Scripts/core.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AboutScript").Include(
                      "~/Scripts/about-script.js"));
        }
    }
}
