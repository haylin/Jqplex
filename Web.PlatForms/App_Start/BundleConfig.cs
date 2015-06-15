using System.Web;
using System.Web.Optimization;

namespace Web.PlatForms
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/topdrow").Include(
                "~/Scripts/Metro/back-to-top.js",
                "~/Scripts/Metro/hover-dropdown.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/Default").Include(
                "~/Scripts/Metro/jquery-m*",             
                "~/Scripts/Metro/jquery.f*",
                   "~/Scripts/Metro/jquery.themepunch.plugins.min.js",
                "~/Scripts/metro/jquery.t*",
                "~/Scripts/Metro/app.js",
                "~/Scripts/Metro/index.js",
                 "~/Scripts/Metro/jquery.b*"
             



                ));
            #endregion

            bundles.Add(new ScriptBundle("~/bundles/IE9").Include(
              "~/Scripts/respond.js"

              ));



            #region 前台
            bundles.Add(new ScriptBundle("~/bundles/boot").Include("~/scripts/bootstrap*"));
            #endregion




            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #region 前台样式
            bundles.Add(new StyleBundle("~/Content/boot").Include("~/Content/bootstrap.css",
                   "~/Content/flat-ui.css"));
            #endregion

            bundles.Add(new StyleBundle("~/Content/Default").Include(
                  "~/Content/Metro/font-*",
                  "~/Content/Metro/bootstrap.css",
                  "~/Content/Metro/uniform.default.css"
          ));
            bundles.Add(new StyleBundle("~/Content/Page").Include(
                "~/Content/Metro/jquery.fancybox.css",
                "~/Content/Metro/rs.style.css",
                "~/Content/Metro/settings.css",
                "~/Content/Metro/jquery.bxslider.css",
                "~/Content/Metro/style-*",
                "~/Content/Metro/style.css",
                "~/Content/Metro/custom.css"
                ));

        }
    }
}
