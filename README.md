# Soenneker.Maui.Firebase.Crashlytics
[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.crashlytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.crashlytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.crashlytics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.crashlytics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.crashlytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.crashlytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.crashlytics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.crashlytics/actions/workflows/codeql.yml)

Adds Firebase Crashlytics collection to the Android and iOS lifecycle configured by `Soenneker.Maui.Firebase`.

## Installation

```bash
dotnet add package Soenneker.Maui.Firebase.Crashlytics
```

Configure the native Firebase app first, including the platform's `google-services.json` or `GoogleService-Info.plist`.

## Registration

Attach Crashlytics before completing the Firebase builder:

```csharp
using Soenneker.Maui.Firebase.Crashlytics.Registrars;
using Soenneker.Maui.Firebase.Dtos;
using Soenneker.Maui.Firebase.Registrars;

builder.UseFirebase(new FirebaseConfig())
       .AddCrashlytics()
       .Build();
```

`AddCrashlytics()` enables native crash collection. If collection depends on consent, pass that decision explicitly:

```csharp
builder.UseFirebase(new FirebaseConfig())
       .AddCrashlytics(collectionEnabled: userAllowsCrashReporting)
       .Build();
```

The choice is applied when the native Firebase app initializes. Changing consent later requires calling the platform Crashlytics SDK directly.

This package enables the native Crashlytics integration; it is not an `ILogger` provider and does not expose an abstraction for recording handled exceptions. Confirm that the platform build produces the symbol or mapping uploads required by the Firebase setup, then verify a test crash appears in the Firebase console before relying on production reports.
