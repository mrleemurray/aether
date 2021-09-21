﻿using SixLabors.ImageSharp;

namespace Aether.Devices.Drivers
{
    internal abstract class DisplayDriver : IDisposable
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract float DpiX { get; }
        public abstract float DpiY { get; }

        public abstract Image CreateImage();

        public abstract void DisplayImage(Image image, DrawOrientation orientation = DrawOrientation.Landscape);

        public abstract void Dispose();
    }
}