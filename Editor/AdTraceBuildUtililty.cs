using UnityEditor;
using UnityEngine;

namespace GameWarriors.AdTrace.Editor
{
    public static class AdTraceBuildUtililty
    {
        public static void SetIosLibraryState(bool isEnable)
        {
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTAdRevenue.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTAttribution.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTConfig.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTEvent.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTEventFailure.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTEventSuccess.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTLinkResolution.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/AdTrace.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/AdTraceUnity.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/AdTraceUnity.mm", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/AdTraceUnityDelegate.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/AdTraceUnityDelegate.mm", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTSessionFailure.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTSessionSuccess.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTSubscription.h", isEnable, BuildTarget.iOS);
            SetEnabled("Packages/com.gamewarriors.adtrace/Plugins/iOS/ADTThirdPartySharing.h", isEnable, BuildTarget.iOS);
        }

        public static void SetEnabled(string packagePath, bool enabled, BuildTarget buildTarget = BuildTarget.Android)
        {
            var importer = AssetImporter.GetAtPath(packagePath) as PluginImporter;

            if (importer != null)
            {
                importer.SetCompatibleWithPlatform(buildTarget, enabled);
                importer.SaveAndReimport();
            }
            else
            {
                Debug.LogWarning($"{packagePath} not found");
            }
        }
    }
}
