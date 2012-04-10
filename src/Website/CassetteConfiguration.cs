﻿using Cassette;
using Cassette.Configuration;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace Website
{
    public class CassetteConfiguration : IBundleDefinition
    {
        public void AddBundles(BundleCollection bundles)
        {
            bundles.Add<StylesheetBundle>("assets/styles");
            bundles.Add<StylesheetBundle>("assets/iestyles", b => b.Condition = "IE");

            bundles.AddPerSubDirectory<ScriptBundle>("assets/scripts");
            bundles.AddUrlWithLocalAssets(
                "//ajax.googleapis.com/ajax/libs/jquery/1.6.3/jquery.min.js",
                new LocalAssetSettings
                {
                    FallbackCondition = "!window.jQuery",
                    Path = "assets/scripts/jquery"
                }
            );
        }
    }
}