using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;

namespace AppIconUtil.Generators
{
    public abstract class PlatformGeneratorBase : IPlatformIconGenerator
    {
        protected IReadOnlyList<IconRegistration> PlatformIconRegistrations { get; }

        protected IconStatus Status { get; private set; }

        protected string FilePath { get; private set; }

        public PlatformGeneratorBase()
        {
            PlatformIconRegistrations = GetPlatformIcons();
        }

        public void GenerateIcons(string projectPath, string iconPath)
        {
            if (!Directory.Exists(projectPath))
                throw new FileNotFoundException($"The file {Path.GetFileName(projectPath)} could not be found.");
            if (!File.Exists(iconPath))
                throw new FileNotFoundException($"The file {Path.GetFileName(iconPath)} could not be found");

            foreach (var icon in PlatformIconRegistrations)
            {
                GenerateIcon(projectPath, iconPath, icon);
            }

            DoPlatformSpecificGenerations(projectPath, iconPath);
        }

        public IconStatus GetStatus() => Status;

        public IconStatus GetStatus(string iconPath)
        {
            if (!File.Exists(iconPath))
                return Status = IconStatus.NotAvailable;

            if (HasTransparentBackground(iconPath))
                return Status = IconStatus.HasTransparency;

            return Status = IconStatus.ReadyToProcess;
        }

        private bool HasTransparentBackground(string iconPath)
        {
            return false;
        }

        protected virtual void DoPlatformSpecificGenerations(string projectPath, string iconPath)
        {

        }

        protected void GenerateIcon(string projectPath, string iconPath, IconRegistration icon)
        {
            var outputPath = Path.Combine(projectPath, icon.ProjectPath);
            //var settings = new ResizeSettings(icon.Width, icon.Height, FitMode.Carve, "png");
            //ImageBuilder.Current.Build(iconPath, outputPath, settings);
            using (var inStream = File.Open(iconPath, FileMode.Open))
            using (var outStream = File.Create(outputPath))
            using (ImageFactory imageFactory = new ImageFactory())
            {
                // Load, resize, set the format, and quality and save an image.
                imageFactory.Load(inStream)
                            .Resize(new Size((int)icon.Width, (int)icon.Height))
                            .Format(new PngFormat())
                            .Quality(100)
                            .Save(outStream);

                // Use the outStream.
                // E.g. byte[] resizedImage = outStream.ToArray();
            }
        }

        protected abstract IReadOnlyList<IconRegistration> GetPlatformIcons();

        protected struct IconRegistration
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public string ProjectPath { get; set; }
        }

        private void GetImage(string iconPath)
        {
            byte[] photoBytes = File.ReadAllBytes(iconPath);
            // Format is automatically detected though can be changed.
            ISupportedImageFormat format = new PngFormat { Quality = 100 };
            //Size size = new Size(150, 0);
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    //.Resize(size)
                                    .Format(format)
                                    .Save(outStream);
                    }
                    // Do something with the stream.
                }
            }
        }
    }
}
