using System.Web;
using System.Web.Optimization;

namespace FlavaSolutionsFinal
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Theme/css").Include(
                     "~/Theme/vendor/fontawesome-free/css/all.min.css",
                      "~/Theme/vendor/datatables/dataTables.bootstrap4.css",
                       "~/Theme/css/sb-admin.css"));

            bundles.Add(new ScriptBundle("~/Theme/js").Include(
                     "~/Scripts/Theme/vendor/jquery/jquery.min.js",
                     "~/Scripts/Theme/vendor/bootstrap/js/bootstrap.bundle.min.js",
                     "~/Scripts/Theme/vendor/jquery-easing/jquery.easing.min.js",
                     "~/Scripts/Theme/vendor/chart.js/Chart.min.js",
                     "~/Scripts/Theme/vendor/datatables/jquery.dataTables.js",
                     "~/Scripts/Theme/vendor/datatables/dataTables.bootstrap4.js",
                     "~/Scripts/Theme/js/sb-admin.min.js",
                     "~/Scripts/Theme/js/demo/datatables-demo.js",
                      "~/Scripts/Theme/js/demo/chart-area-demo.js"));
        }
    }
}
