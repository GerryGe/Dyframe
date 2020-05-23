﻿using System.Linq;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Dychar.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Bundling
{
    public class StislaThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.RemoveAll(x => x.Contains("bootstrap.css"));
            context.Files.Add("/themes/stisla/assets/modules/bootstrap/css/bootstrap.css");
            context.Files.Add("/themes/stisla/assets/modules/fontawesome/css/all.css");
            context.Files.Add("/themes/stisla/assets/css/style.css");
            context.Files.Add("/themes/stisla/assets/css/components.css");
            context.Files.Add("/themes/stisla/assets/css/custom.css");
        }
    }
}
