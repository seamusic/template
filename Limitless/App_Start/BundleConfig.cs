using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Limitless
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.ResetAll();

            bundles.Add(new StyleBundle("~/Content/css/base")
                .Include("~/Content/css/icons/icomoon/styles.css",
                "~/Content/css/bootstrap.css",
                "~/Content/css/core.css",
                "~/Content/css/components.css",
                "~/Content/css/colors.css"));

            bundles.Add(new ScriptBundle("~/Scripts/core")
                .Include("~/Scripts/plugins/loaders/pace.min.js",
                    "~/Scripts/core/libraries/jquery.min.js",
                    "~/Scripts/core/libraries/bootstrap.min.js",
                    "~/Scripts/plugins/loaders/blockui.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/theme")
                .Include("~/Scripts/plugins/visualization/d3/d3.min.js",
                    "~/Scripts/plugins/visualization/d3/d3_tooltip.js",
                    "~/Scripts/plugins/forms/styling/switchery.min.js",
                    "~/Scripts/plugins/forms/styling/uniform.min.js",
                    "~/Scripts/plugins/forms/selects/bootstrap_multiselect.js",
                    "~/Scripts/plugins/ui/moment/moment.min.js",
                    "~/Scripts/plugins/pickers/daterangepicker.js"));
        }
    }
}