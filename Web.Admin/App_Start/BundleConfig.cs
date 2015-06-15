using System.Web;
using System.Web.Optimization;

namespace Web.Admin
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region jquery原库
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                           "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/scripts/bootstrap*"));
            #endregion


            bundles.Add(new ScriptBundle("~/bundles/IE9").Include(
                "~/Scripts/Metro/respond.min.js",
                "~/Scripts/Metro/excanvas.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Default").Include(
                "~/Scripts/Metro/jquery-*",
                "~/Scripts/Metro/jquery.slimscroll.js",
                "~/Scripts/Metro/jquery.blockui.min.js",
                 "~/Scripts/Metro/jquery.cookie.min.js",
                  "~/Scripts/Metro/jquery.uniform.js",
                  "~/Scripts/Metro/select2.js",
                  "~/Scripts/Metro/app.js"



                ));
            bundles.Add(new ScriptBundle("~/bundles/Twitter").Include(
                "~/Scripts/Metro/twitter-*"
                ));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/boot").Include("~/Content/bootstrap.css",
                  "~/Content/flat-ui.css"));

            bundles.Add(new ScriptBundle("~/Content/msg").Include("~/Content/messager/messe*"));

            #region 系统登录样式
            bundles.Add(new StyleBundle("~/Content/flatui").Include(
                     "~/Content/flatuilogin/templatemo_style.css"));

            bundles.Add(new StyleBundle("~/Content/Default").Include(
                "~/Content/Metro/font-awesome.css",
                "~/Content/Metro/bootstrap.css",
                "~/Content/Metro/uniform.default.css"
                ));
            bundles.Add(new StyleBundle("~/Content/Metro").Include(
                "~/Content/Metro/select_metro.css"
                ));
            bundles.Add(new StyleBundle("~/Content/Theme").Include(
                "~/Content/Metro/Theme/style-metronic.css",
                "~/Content/Metro/Theme/style.css",
                "~/Content/Metro/Theme/style-responsive.css",
                "~/Content/Metro/Theme/plugins.css",
                //"~/Content/Metro/Theme/default.css",
                "~/Content/Metro/Theme/custom.css"
                ));

            #endregion
        }
    }
}
