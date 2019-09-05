using System.Web;
using System.Web.Optimization;

namespace ekscarMVC
{
    public class BundleConfig
    {
        // Paketleme hakkında daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkId=301862 adresini ziyaret edin
        public static void RegisterBundles(BundleCollection bundles)
        {


            // Geliştirme yapmak ve öğrenmek için Modernizr'ın geliştirme sürümünü kullanın. Daha sonra,
            // üretim için hazır. https://modernizr.com adresinde derleme aracını kullanarak yalnızca ihtiyacınız olan testleri seçin.

            bundles.Add(new ScriptBundle("~/Scripts/Base").Include(
                        "~/assets/js/jquery.min.js",
                        "~/assets/js/modernizr.js",
                        "~/assets/js/script.js",
                        "~/assets/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Template").Include(
              "~/assets/js/wow.min.js",
               "~/assets/js/slick.min.js",
                "~/assets/js/parallax.js",
                 "~/assets/js/select-chosen.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Custom").Include(
                "~/assets/js/custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new StyleBundle("~/Styles/Template").Include(
          "~/assets/css/bootstrap-grid.css",
          "~/assets/css/icons.css",
           "~/assets/css/animate.min.css",
            "~/assets/css/style.css",
             "~/assets/css/responsive.css",
              "~/assets/css/chosen.css",
               "~/assets/css/colors/colors.css",
                "~/assets/css/bootstrap.css",
                 "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Styles/Custom").Include(
             "~/assets/css/custom.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
