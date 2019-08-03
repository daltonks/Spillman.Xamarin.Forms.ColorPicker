# Spillman.Xamarin.Forms.ColorPicker

Nice looking HSV color picker for Xamarin Forms with alpha and hex support.

[Little video](https://www.youtube.com/watch?v=A5GesThEogo)

![Color picker screenshot](screenshot.png)

# To use
- Install `SkiaSharp` and `SkiaSharp.Views.Forms` into your app projects
- Install the [NuGet package](https://www.nuget.org/packages/Spillman.Xamarin.Forms.ColorPicker/)
- Add `ColorPickerView` to a view
- Set the `ColorPickerView`'s `BindingContext` to an instance of `ColorPickerViewModel`
- Access the color values through the `ColorPickerViewModel` (`Color`, `SKColor`, `HueColor`, `Hex`, `A`, `H`, `S`, `V`)
