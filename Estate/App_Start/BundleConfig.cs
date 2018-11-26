using System.Web;
using System.Web.Optimization;

namespace Estate
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate.min.js",
                        "~/Scripts/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/assets").Include(
                      "~/Scripts/assets/vendor/hs-megamenu/src/hs.megamenu.js",
                    "~/Scripts/assets/vendor/jquery-ui/ui/widget.js",
                    "~/Scripts/assets/vendor/jquery-ui/ui/widgets/menu.js",
                    "~/Scripts/assets/vendor/jquery-ui/ui/widgets/mouse.js",
                    "~/Scripts/assets/vendor/jquery-ui/ui/widgets/slider.js",
                    "~/Scripts/assets/vendor/chosen/chosen.jquery.js",
                    "~/Scripts/assets/vendor/slick-carousel/slick/slick.js",
                    "~/Scripts/assets/vendor/fancybox/jquery.fancybox.min.js",

                    "~/Scripts/assets/js/hs.core.js",
                    "~/Scripts/assets/js/components/hs.header.js",
                    "~/Scripts/assets/js/helpers/hs.hamburgers.js",
                    "~/Scripts/assets/js/components/hs.dropdown.js",
                    "~/Scripts/assets/js/components/hs.slider.js",
                    "~/Scripts/assets/js/components/hs.select.js",
                    "~/Scripts/assets/js/components/hs.carousel.js",
                    "~/Scripts/assets/js/components/hs.popup.js",
                    "~/Scripts/assets/js/components/hs.go-to.js",

                    "~/Scripts/assets/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/ass").Include(
                    "~/Scripts/assets/vendor/icon-awesome/css/font-awesome.min.css",
                    "~/Scripts/assets/vendor/icon-line/css/simple-line-icons.css",
                    "~/Scripts/assets/vendor/icon-line-pro/style.css",
                    "~/Scripts/assets/vendor/icon-hs/style.css",
                    "~/Scripts/assets/vendor/animate.css",
                    "~/Scripts/assets/vendor/hs-megamenu/src/hs.megamenu.css",
                    "~/Scripts/assets/vendor/hamburgers/hamburgers.min.css",
                    "~/Scripts/assets/vendor/chosen/chosen.css",
                    "~/Scripts/assets/vendor/slick-carousel/slick/slick.css",
                    "~/Scripts/assets/vendor/fancybox/jquery.fancybox.min.css",
                    "~/Content/assets/css/styles.multipage-real-estate-blue.css",
                    //"~/Content/assets/css/styles.multipage-real-estate.css",

                    "~/Content/assets/css/custom.css"));
        }
    }
}
