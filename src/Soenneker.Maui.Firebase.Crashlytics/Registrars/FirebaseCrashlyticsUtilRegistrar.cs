#if ANDROID
using Firebase.Crashlytics;
#endif

#if IOS
using Firebase.Crashlytics;
#endif

namespace Soenneker.Maui.Firebase.Crashlytics.Registrars;

/// <summary>
/// Represents the crashlytics extensions.
/// </summary>
public static class CrashlyticsExtensions
{
    /// <summary>
    /// Adds Firebase Crashlytics and configures automatic crash collection.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <param name="collectionEnabled">Whether the native SDK may collect crash reports.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FirebaseMauiBuilder AddCrashlytics(this FirebaseMauiBuilder builder, bool collectionEnabled = true)
    {
#pragma warning disable CA1416 // The referenced Firebase package has malformed platform metadata; this project is platform-targeted.
        return builder.AddService((firebaseInstance, config) =>
#pragma warning restore CA1416
        {
#if ANDROID
#pragma warning disable CA1422 // The current binding only accepts Java.Lang.Boolean.
            using var enabled = new Java.Lang.Boolean(collectionEnabled);
            FirebaseCrashlytics.Instance.SetCrashlyticsCollectionEnabled(enabled);
#pragma warning restore CA1422
#endif

#if IOS
            global::Firebase.Crashlytics.Crashlytics.SharedInstance.SetCrashlyticsCollectionEnabled(collectionEnabled);
#endif
        });
    }
}
