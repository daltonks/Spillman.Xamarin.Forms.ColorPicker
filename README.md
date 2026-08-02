# Spillman.Xamarin.Forms.ColorPicker

[![NuGet](https://img.shields.io/nuget/v/Spillman.Xamarin.Forms.ColorPicker?label=Spillman.Xamarin.Forms.ColorPicker)](https://www.nuget.org/packages/Spillman.Xamarin.Forms.ColorPicker)

An HSV color picker for Xamarin.Forms, with an alpha slider and hex entry. It's drawn with SkiaSharp, so it looks and behaves the same on every platform.

![Color picker screenshot](screenshot.png)

[Short video of it in use](https://www.youtube.com/watch?v=A5GesThEogo)

## Install

Into your shared project and each platform project:

```
dotnet add package Spillman.Xamarin.Forms.ColorPicker
dotnet add package SkiaSharp
dotnet add package SkiaSharp.Views.Forms
```

## Use

Drop the view in and give it a `ColorPickerViewModel` as its binding context:

```xml
<ContentPage
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:colorPicker="clr-namespace:Spillman.Xamarin.Forms.ColorPicker;assembly=Spillman.Xamarin.Forms.ColorPicker"
    x:Class="Example.MainPage">

    <ContentPage.BindingContext>
        <colorPicker:ColorPickerViewModel />
    </ContentPage.BindingContext>

    <colorPicker:ColorPickerView HorizontalOptions="Center" VerticalOptions="Center" />
</ContentPage>
```

Read the color off the view model, or hold your own instance and bind to it:

```cs
var viewModel = new ColorPickerViewModel { Color = Color.Rebeccapurple };
viewModel.PropertyChanged += (_, e) =>
{
    if (e.PropertyName == nameof(ColorPickerViewModel.Color))
    {
        Apply(viewModel.Color);
    }
};
```

## ColorPickerViewModel

| Member | Type | Notes |
| --- | --- | --- |
| `Color` | `Xamarin.Forms.Color` | The selected color. Assigning one moves the picker. |
| `SKColor` | `SkiaSharp.SKColor` | The same color, for when you are drawing with Skia anyway. Read-only. |
| `HueColor` | `Color` | The pure hue at full saturation and value, handy for tinting your own chrome. Read-only. |
| `Hex` | `string` | Six hex digits, `RRGGBB`. Alpha isn't included; that's `A`. Non-hex characters get filtered out as you type. |
| `A` | `byte` | Alpha, 0 to 255. |
| `H` | `float` | Hue, 0 to 360. |
| `S` | `float` | Saturation, 0 to 100. |
| `V` | `float` | Value, 0 to 100. |
| `IsAlphaEnabled` | `bool` | Set false to hide the alpha slider. Defaults to true. |
| `IsHexEnabled` | `bool` | Set false to hide the hex field. Defaults to true. |

The view model implements `INotifyPropertyChanged`. Every component also raises a change for `Color`, so binding to `Color` alone is enough.

## Example app

[`source/Example`](source/Example) is a small Xamarin.Forms app with the picker on a page, for Android, iOS, and UWP.

## A note on Xamarin.Forms

Xamarin.Forms reached end of support in May 2024. This package still works against Xamarin.Forms 5. It hasn't been ported to .NET MAUI.

## License

MIT.
