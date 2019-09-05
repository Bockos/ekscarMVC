using System.Web;
using System.Web.Optimization;

namespace ekscarMVC
{
    public class BundleConfig
    {
        // Paketleme hakkında daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkId=301862 adresini ziyaret edin
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Geliştirme yapmak ve öğrenmek için Modernizr'ın geliştirme sürümünü kullanın. Daha sonra,
            // üretim için hazır. https://modernizr.com adresinde derleme aracını kullanarak yalnızca ihtiyacınız olan testleri seçin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/assets/js/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                     "~/assets/js/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/other").Include(
                   "~/assets/js/wow.min.js",
                    "~/assets/js/slick.min.js",
                     "~/assets/js/parallax.js",
                      "~/assets/js/select-chosen.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
          "~/assets/css/bootstrap-grid.css",
          "~/assets/css/icons.css",
           "~/assets/css/animate.min.css",
            "~/assets/css/style.css",
             "~/assets/css/responsive.css",
              "~/assets/css/chosen.css",
               "~/assets/css/colors/colors.css",
                "~/assets/css/bootstrap.css",
                 "~/Content/font-awesome.min.css"));
        }
    }
}
