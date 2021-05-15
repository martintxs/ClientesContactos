using System.Web;
using System.Web.Optimization;

namespace ClientesContactos
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                     //Bootstrap
                     "~/Content/CSS/Plugin/Bootstrap/bootstrap.min.css",
                     //Data tables
                     "~/Content/CSS/Plugin/DataTables/dataTables.css",
                     //Font awesome
                     "~/Content/CSS/General/all.min.css",
                     //jQuery UI
                     "~/Content/CSS/Plugin/jQueryUI/jquery-ui.min.css"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Plugins/Modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                     //jQuery
                     "~/Scripts/Plugins/JQuery/jquery-3.4.1.js",
                     //Bootstrap         
                     "~/Scripts/Plugins/popper.js",
                     "~/Scripts/Plugins/Bootstrap/bootstrap.min.js",
                     //"~/Scripts/Plugins/Bootstrap/jquery.timepicker.min.js",
                     //Font Awesome
                     "~/Scripts/Plugins/Custom/all.min.js",
                     //Data tables
                     "~/Scripts/Plugins/DataTables/dataTables-jquery.js",
                     "~/Scripts/Plugins/DataTables/dataTables-bootstrap.js",
                     "~/Scripts/Plugins/DataTables/dataTables.js",
                     //Sweer Alert
                     "~/Scripts/Plugins/SweetAlert/sweet-alert.js",
                     //jQuery UI
                     "~/Scripts/Plugins/JQuery/jquery-ui.min.js",
                     //Moment
                     "~/Scripts/Plugins/Moment/moment.js",

                     //Custom
                     "~/Scripts/Proyecto/General/FuncionesGenerales.js",
                     "~/Scripts/Proyecto/General/Mensajes.js"));
        }
    }
}
