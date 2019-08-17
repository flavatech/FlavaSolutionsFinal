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

            bundles.Add(new ScriptBundle("~/bundles/Date").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js",
                        "~/Content/themes/base/jquery-ui.min.css"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Theme/Css").Include(
                     "~/Theme/css/bootstrap.min.css",
                      "~/Theme/css/sb-admin.css",
                      "~/Theme/css/plugins/morris.css",
                      "~/Theme/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Theme1(Not Used)/css").Include(
                     "~/Theme1/css/bootstrap.min.css",
                      "~/Theme1/css/sb-admin.css",
                      "~/Theme1/font-awesome/css/font-awesome.min.css",
                       "~/Theme1/css/plugins/morris.css"));

            bundles.Add(new StyleBundle("~/Theme2/Css").Include(
                    "~/Theme2/css/linearicons.css",
                     "~/Theme2/css/font-awesome.min.css",
                     "~/Theme2/css/bootstrap.css",
                      "~/Theme2/css/magnific-popup.css",
                       "~/Theme2/css/nice-select.css",
                     "~/Theme2/css/animate.min.css",
                     "~/Theme2/css/owl.carousel.css",
                      "~/Theme2/css/main.css"));


            bundles.Add(new StyleBundle("~/Theme1/SBadmin1/Css").Include(
                    "~/Theme1/SBadmin1/vendor/fontawesome-free/css/all.min.css",
                    "~/Theme1/SBadmin1/vendor/datatables/dataTables.bootstrap4.css",
                    "~/Theme1/SBadmin1/css/sb-admin.css"
                     ));

            

            bundles.Add(new ScriptBundle("~/Theme/Js").Include(
                     "~/Scripts/Theme/js/jquery.js",
                     "~/Scripts/Theme/js/bootstrap.min.js",
                     "~/Scripts/Theme/js/plugins/morris/raphael.min.js",
                       "~/Scripts/Theme1/js/plugins/morris/morris.min.js",
                       "~/Scripts/Theme1/js/plugins/morris/morris-data.js"));

            bundles.Add(new ScriptBundle("~/Theme1(Not Used)/js").Include(
                     "~/Scripts/Theme1/js/jquery.js",
                     "~/Scripts/Theme1/js/bootstrap.min.js",
                     "~/Scripts/Theme1/js/plugins/morris/raphael.min.js",
                     "~/Scripts/Theme1/js/plugins/morris/morris.min.js",
                       "~/Scripts/Theme1/js/plugins/morris/morris-data.js"));

            bundles.Add(new ScriptBundle("~/Theme1/SBAdmin1/Js").Include(
                     "~/Theme1/SBadmin1/vendor/jquery/jquery.min.js",
                     "~/Theme1/SBadmin1/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/Theme1/SBadmin1/vendor/jquery-easing/jquery.easing.min.js",
                    "~/Theme1/SBadmin1/vendor/chart.js/Chart.min.js",
                     "~/Theme1/SBadmin1/vendor/datatables/jquery.dataTables.js",
                    "~/Theme1/SBadmin1/vendor/datatables/dataTables.bootstrap4.js",
                    "~/Theme1/SBadmin1/js/sb-admin.min.js",
                    "~/Theme1/SBadmin1/js/demo/datatables-demo.js",
                    "~/Theme1/SBadmin1/js/demo/chart-area-demo.js"));

            bundles.Add(new ScriptBundle("~/Theme2/Js").Include(
                    "~/Theme2/js/vendor/jquery-2.2.4.min.js",
                    "~/Theme2/https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js",
                   "~/Theme2/js/vendor/bootstrap.min.js",
                   "~/Theme2/text/javascript",
                   "~/Theme2/js/easing.min.js",
                    "~/Theme2/js/hoverIntent.js",
                   "~/Theme2/js/superfish.min.js",
                   "~/Theme2/js/jquery.ajaxchimp.min.js",
                   "~/Theme2/js/jquery.magnific-popup.min.js",
                   "~/Theme2/js/owl.carousel.min.js",
                   "~/Theme2/js/jquery.sticky.js",
                   "~/Theme2/js/jquery.nice-select.min.js",
                   "~/Theme2/js/parallax.min.js",
                   "~/Theme2/js/waypoints.min.js",
                   "~/Theme2/js/jquery.counterup.min.js",
                   "~/Theme2/js/mail-script.js",
                   "~/Theme2/js/main.js"));






        }
    }
}
