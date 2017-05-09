using System.Web.Optimization;

namespace TaskList.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Datatables
            bundles.Add(new ScriptBundle("~/bundles/datatables/js").Include(
                      "~/Scripts/datatables/media/js/jquery.dataTables.min.js"));

            // Datatables bootstrap
            bundles.Add(new ScriptBundle("~/bundles/datatablesBootstrap/js").Include(
                      "~/Scripts/datatables.net-bs/js/dataTables.bootstrap.min.js"));

            // Datatables plugins
            bundles.Add(new ScriptBundle("~/bundles/datatablesPlugins/js").Include(
                      //"~/Scripts/pdfmake/build/pdfmake.min.js",
                      //"~/Scripts/pdfmake/build/vfs_fonts.js",
                      "~/Scripts/datatables.net-buttons/js/buttons.html5.min.js",
                      "~/Scripts/datatables.net-buttons/js/buttons.print.min.js",
                      "~/Scripts/datatables.net-buttons/js/dataTables.buttons.min.js",
                      "~/Scripts/datatables.net-buttons-bs/js/buttons.bootstrap.min.js"));

            // Datatables style
            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include(
                      "~/Scripts/datatables.net-bs/css/dataTables.bootstrap.min.css"));
        }
    }
}
