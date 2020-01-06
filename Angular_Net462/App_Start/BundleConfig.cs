using System.Web.Optimization;

namespace Angular_Net462
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
