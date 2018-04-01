using System;
using System.Collections.Generic;

namespace AppIconUtil.Generators
{
    public sealed class AndroidIconGenerator : PlatformGeneratorBase
    {
        protected override IReadOnlyList<IconRegistration> GetPlatformIcons()
        {
            return new List<IconRegistration>
            {
                new IconRegistration
                {
                    Height = 72,
                    Width = 72,
                    ProjectPath = "Resources/mipmap-hdpi/ic_launcher.png"
                },
                new IconRegistration
                {
                    Height = 36,
                    Width = 36,
                    ProjectPath = "Resources/mipmap-ldpi/ic_launcher.png"
                },
                new IconRegistration
                {
                    Height = 48,
                    Width = 48,
                    ProjectPath = "Resources/mipmap-mdpi/ic_launcher.png"
                },
                new IconRegistration
                {
                    Height = 96,
                    Width = 96,
                    ProjectPath = "Resources/mipmap-xhdpi/ic_launcher.png"
                },
                new IconRegistration
                {
                    Height = 144,
                    Width = 144,
                    ProjectPath = "Resources/mipmap-xxhdpi/ic_launcher.png"
                },
                new IconRegistration
                {
                    Height = 192,
                    Width = 192,
                    ProjectPath = "Resources/mipmap-xxxhdpi/ic_launcher.png"
                },
            };
        }
    }
}
