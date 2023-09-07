# WebIdentifiers.Css
Provides constant definitions for identifiers used in CSS including properties and values.

![Nuget](https://img.shields.io/nuget/v/WebIdentifiers.Css)

## Overview
This package provides the string values for various CSS identifiers.

### CssProperties
The `CssValues` static class provides constant values for CSS property names. 

```csharp
var tag = $"{CssProperties.Display}: none;";
Console.WriteLine(tag); // output: display: none;
```

### CssValues
The `CssValues' static class provides predefined values and helper methods for building CSS property values.

```csharp
var idAttribute = $"{CssProperties}.Display}: {CssValues.None};";
Console.WriteLine(idAttribute); // output: display: none;
```

Values that are known to be valid for various CSS properties are also made available 
though static read only "For" members.

```csharp
var attribute = $"{CssProperties.Display}: {CssValues.ForDisplay.None}";
Console.WriteLine(attribute); // output: display: none;
```