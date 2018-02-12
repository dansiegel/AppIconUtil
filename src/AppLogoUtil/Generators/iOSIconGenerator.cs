using System;
using System.Collections.Generic;

namespace AppLogoUtil.Generators
{
    public sealed class iOSIconGenerator : PlatformGeneratorBase
    {
        protected override IReadOnlyList<IconRegistration> GetPlatformIcons()
        {
            return new List<IconRegistration>
            {
                new IconRegistration
                {
                    Height = 20,
                    Width = 20,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-20x20@1x.png"
                },
                new IconRegistration
                {
                    Height = 40,
                    Width = 40,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-20x20@2x.png"
                },
                new IconRegistration
                {
                    Height = 60,
                    Width = 60,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-20x20@3x.png"
                },
                new IconRegistration
                {
                    Height = 29,
                    Width = 29,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-29x29@1x.png"
                },
                new IconRegistration
                {
                    Height = 58,
                    Width = 58,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-29x29@2x.png"
                },
                new IconRegistration
                {
                    Height = 87,
                    Width = 87,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-29x29@3x.png"
                },
                new IconRegistration
                {
                    Height = 40,
                    Width = 40,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-40x40@1x.png"
                },
                new IconRegistration
                {
                    Height = 80,
                    Width = 80,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-40x40@2x.png"
                },
                new IconRegistration
                {
                    Height = 120,
                    Width = 120,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-40x40@3x.png"
                },
                new IconRegistration
                {
                    Height = 57,
                    Width = 57,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-57x57@1x.png"
                },
                new IconRegistration
                {
                    Height = 114,
                    Width = 114,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-57x57@2x.png"
                },
                new IconRegistration
                {
                    Height = 60,
                    Width = 60,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-60x60@1x.png"
                },
                new IconRegistration
                {
                    Height = 120,
                    Width = 120,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-60x60@2x.png"
                },
                new IconRegistration
                {
                    Height = 180,
                    Width = 180,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-60x60@3x.png"
                },
                new IconRegistration
                {
                    Height = 72,
                    Width = 72,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-72x72@1x.png"
                },
                new IconRegistration
                {
                    Height = 144,
                    Width = 144,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-72x72@2x.png"
                },
                new IconRegistration
                {
                    Height = 76,
                    Width = 76,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-76x76@1x.png"
                },
                new IconRegistration
                {
                    Height = 152,
                    Width = 152,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-76x76@2x.png"
                },
                new IconRegistration
                {
                    Height = 228,
                    Width = 228,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-76x76@3x.png"
                },
                new IconRegistration
                {
                    Height = 167,
                    Width = 167,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-83.5x83.5@2x.png"
                },
                new IconRegistration
                {
                    Height = 50,
                    Width = 50,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-50x50@1x.png"
                },
                new IconRegistration
                {
                    Height = 100,
                    Width = 100,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-App-50x50@2x.png"
                },
                new IconRegistration
                {
                    Height = 50,
                    Width = 50,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-Small-50x50@1x.png"
                },
                new IconRegistration
                {
                    Height = 100,
                    Width = 100,
                    ProjectPath = "Assets.xcassets/AppIcon.appiconset/Icon-Small-50x50@2x.png"
                },
                new IconRegistration
                {
                    Height = 76,
                    Width = 76,
                    ProjectPath = "Resources/AppIcon@1x.png"
                },
                new IconRegistration
                {
                    Height = 152,
                    Width = 152,
                    ProjectPath = "Resources/AppIcon@2x.png"
                },
                new IconRegistration
                {
                    Height = 228,
                    Width = 228,
                    ProjectPath = "Resources/AppIcon@3x.png"
                },
                new IconRegistration
                {
                    Height = 512,
                    Width = 512,
                    ProjectPath = "Resources/iTunesArtwork@1x.png"
                },
                new IconRegistration
                {
                    Height = 1024,
                    Width = 1024,
                    ProjectPath = "Resources/iTunesArtwork@2x.png"
                },
                new IconRegistration
                {
                    Height = 1536,
                    Width = 1536,
                    ProjectPath = "Resources/iTunesArtwork@3x.png"
                }
            };
        }
    }
}
