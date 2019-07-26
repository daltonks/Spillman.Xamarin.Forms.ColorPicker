using System;
using Xamarin.Forms;

namespace Spillman.Xamarin.Forms.ColorPicker
{
    internal static class ColorExtensions
    {
        internal static string ToRgbHex(this Color color)
        {
            var r = (byte)Math.Round(color.R * byte.MaxValue);
            var g = (byte)Math.Round(color.G * byte.MaxValue);
            var b = (byte)Math.Round(color.B * byte.MaxValue);

            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}
