using System.Web;
using System.Web.Optimization;

namespace Inspinia
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            // Base style (Base)
            bundles.Add(new StyleBundle("~/Content/base").Include("~/Content/base/animate.css","~/Content/base/style.css"));

            // Bootstrap style (Bootstrap)
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Scripts/bootstrap/css/bootstrap.min.css","~/Scripts/bootstrap/bootstrap-theme.css"));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include("~/Scripts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery/jquery-3.2.1.js"));

            // Bootstrap js
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap/js/bootstrap.min.js"));

            // Base js
            bundles.Add(new ScriptBundle("~/bundles/base").Include("~/Scripts/base/metisMenu.min.js"/*,"~/Scripts/base/pace.min.js"  //顶部进度条*/,"~/Scripts/base/inspinia.js"));

            // skin config script
            bundles.Add(new ScriptBundle("~/bundles/skinConfig").Include("~/Scripts/base/skin.config.min.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include("~/Scripts/slimscroll/jquery.slimscroll.min.js"));

            // iCheck css  
            bundles.Add(new StyleBundle("~/Content/icheck/icheckcss").Include(
                "~/Scripts/icheck/custom.css"));

            // iCheck js
            bundles.Add(new ScriptBundle("~/Scripts/icheck").Include(
                "~/Scripts/icheck/icheck.min.js"));
        }
    }
}
