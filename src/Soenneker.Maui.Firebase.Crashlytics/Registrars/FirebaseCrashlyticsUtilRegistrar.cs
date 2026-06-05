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
    /// Adds crashlytics.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <returns>The result of the operation.</returns>
    public static FirebaseMauiBuilder AddCrashlytics(this FirebaseMauiBuilder builder)
    {
        return builder.AddService((firebaseInstance, config) =>
        {
#if ANDROID
                FirebaseCrashlytics.Instance.SetCrashlyticsCollectionEnabled(new Java.Lang.Boolean(true));
#endif

#if IOS
                global::Firebase.Crashlytics.Crashlytics.SharedInstance.SetCrashlyticsCollectionEnabled(true);
#endif
        });
    }
}