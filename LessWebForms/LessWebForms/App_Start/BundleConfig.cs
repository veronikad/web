using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;

namespace LessWebForms.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                "~/Scripts/WebForms/WebForms.js",
                "~/Scripts/WebForms/WebUIValidation.js",
                "~/Scripts/WebForms/MenuStandards.js",
                "~/Scripts/WebForms/Focus.js",
                "~/Scripts/WebForms/GridView.js",
                "~/Scripts/WebForms/DetailsView.js",
                "~/Scripts/WebForms/TreeView.js",
                "~/Scripts/WebForms/WebParts.js"));

            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/Styles/Site.css",
                "~/Styles/Site2.css"));

            BundleTable.EnableOptimizations = true;
            //var cssTransformer = new CssTransformer();
            ////var nullOrderer = new NullOrderer();

            //var commonStylesBundle = new StyleBundle("~/bundles/commonStyles");
            //commonStylesBundle.Include(
            //   "~/Styles/Site.css",
            //   "~/Styles/main.less",
            //   "~/Styles/default.less");
            //commonStylesBundle.Transforms.Add(cssTransformer);
            ////commonStylesBundle.Orderer = nullOrderer;

            //bundles.Add(commonStylesBundle);
        }
    }

}