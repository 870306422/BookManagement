using System.Web;
using System.Web.Optimization;

namespace BookManagementTwo
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      //  "~/Scripts/bootstrap.js",
                      // "~/Scripts/bootstrap.js",
                      /*--Required vendors*/
                      "~/chaji/vendor/global/global.min.js",
                      "~/chaji/js/quixnav-init.js",
                      "~/chaji/js/custom.min.js",
                      //Vectormap
                      "~/chaji/vendor/raphael/raphael.min.js",
                      "~/chaji/vendor/morris/morris.min.js",

                       "~/chaji/vendor/circle-progress/circle-progress.min.js",
                       "~/chaji/vendor/chart.js/Chart.bundle.min.js",

                       "~/chaji/vendor/gaugeJS/dist/gauge.min.js",

                       //flot - chart js
                       "~/chaji/vendor/flot/jquery.flot.js",
                        "~/chaji/vendor/flot/jquery.flot.resize.js",
                         //Owl Carousel
                         "~/chaji/vendor/owl-carousel/js/owl.carousel.min.js",
                          //Counter Up
                          "~/chaji/vendor/jqvmap/js/jquery.vmap.min.js",
                           "~/chaji/vendor/jqvmap/js/jquery.vmap.usa.js",
                            "~/chaji/vendor/jquery.counterup/jquery.counterup.min.js",
                            "~/chaji/js/dashboard/dashboard-1.js",
                             "~/chaji/bootstrap-table/bootstrap-table.min.js",
                            "~/chaji/bootstrap-table/bootstrap-table-zh-CN.min.js",
                                //"~/Scripts/echarts.min.js",
                                "~/chaji/DataTable/DataTable.js",
                                "~/chaji/bootstrap-fileinput-master/js/fileinput.min.js",
                                "~/chaji/bootstrap-fileinput-master/js/locales/zh.js",
                                "~/chaji/bootstrap-fileinput-master/themes/fa/theme.js",
                                "~/chaji/bootstrap-datetimepicker-master/js/bootstrap-datetimepicker.js",
                                "~/chaji/bootstrap-datetimepicker-master/js/locales/bootstrap-datetimepicker.zh-CN.js"


                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/chaji/vendor/owl-carousel/css/owl.carousel.min.css",
                      "~/chaji/vendor/owl-carousel/css/owl.theme.default.min.css",
                       "~/chaji/vendor/jqvmap/css/jqvmap.min.css",
                        "~/chaji/css/style.css",
                      "~/chaji/site.css",
                      "~/chaji/bootstrap-table/bootstrap-table.min.css",
                      "~/chaji/DataTable/DataTable.css",
                     "~/chaji/bootstrap-fileinput-master/css/fileinput.min.css",
                     "~/chaji/bootstrap-datetimepicker-master/css/bootstrap-datetimepicker.css"));
        }
    }
}
