using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Bundling;

namespace Abp.AspNetCore.Components.WebAssembly.BootstrapTheme
{
    public class BootstrapThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
            context.Add("_content/BootstrapBlazor/js/bootstrap.blazor.bundle.min.js");
            context.Add("_content/Abp.AspNetCore.Components.WebAssembly.BootstrapTheme/scripts/global.js");
            context.Add("_content/Abp.AspNetCore.Components.WebAssembly.BootstrapTheme/scripts/common.js");
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("_content/Syncfusion.Blazor/styles/bootstrap4.css");
            context.Add("_content/BootstrapBlazor/css/bootstrap.blazor.bundle.min.css");
            context.Add("_content/Abp.AspNetCore.Components.WebAssembly.BootstrapTheme/styles/site.css");
            context.Add("_content/Abp.AspNetCore.Components.WebAssembly.BootstrapTheme/styles/loading.css");
        }
    }
}
