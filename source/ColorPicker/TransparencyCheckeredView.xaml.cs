using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms.Xaml;

namespace Spillman.Xamarin.Forms.ColorPicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    partial class TransparencyCheckeredView : SKCanvasView
    {
        public TransparencyCheckeredView()
        {
            InitializeComponent();
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            if (Width < 1)
            {
                return;
            }

            var canvas = e.Surface.Canvas;
            var canvasPixelWidth = e.Info.Width;
            var canvasPixelHeight = e.Info.Height;
            var pixelsPerXamarinUnit = canvasPixelWidth / Width;

            canvas.Clear(SKColors.White);

            var size = (int) Math.Round(8 * pixelsPerXamarinUnit);
            using (var paint = new SKPaint { Color = new SKColor(191, 191, 191) })
            {
                var xOffset = 0;
                for (var y = 0; y < canvasPixelHeight; y += size)
                {
                    xOffset = (xOffset + 1) % 2;

                    for (var x = xOffset * size; x < canvasPixelWidth; x += 2 * size)
                    {
                        canvas.DrawRect(x, y, size, size, paint);
                    }
                }
            }
            
            canvas.Flush();
        }
    }
}