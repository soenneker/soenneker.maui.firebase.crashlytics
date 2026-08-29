[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.crashlytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.crashlytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.crashlytics/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.crashlytics/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.crashlytics.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase.crashlytics/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase.crashlytics/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase.crashlytics/actions/workflows/codeql.yml)

# Soenneker.Maui.Firebase.Crashlytics

Represents the crashlytics extensions.

## Install

```bash
dotnet add package Soenneker.Maui.Firebase.Crashlytics
```

## Quick start

```csharp
using Soenneker.Maui.Firebase.Crashlytics.Registrars;

FirebaseMauiBuilder builder = /* obtain from your application */;
var result = builder.AddCrashlytics();
```

Adds crashlytics.

## What you get

- `CrashlyticsExtensions` — Represents the crashlytics extensions.
