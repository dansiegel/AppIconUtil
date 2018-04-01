using System;
using System.Collections.Generic;

namespace AppIconUtil.Generators
{
    public class UWPIconGenerator : PlatformGeneratorBase
    {
        protected override IReadOnlyList<IconRegistration> GetPlatformIcons()
        {
            return new List<IconRegistration>
            {
                new IconRegistration
                {
                    Height = 24,
                    Width = 24,
                    ProjectPath = "Assets/LockScreenLogo.scale-100.png"
                },
                new IconRegistration
                {
                    Height = 30,
                    Width = 30,
                    ProjectPath = "Assets/LockScreenLogo.scale-125.png"
                },
                new IconRegistration
                {
                    Height = 36,
                    Width = 36,
                    ProjectPath = "Assets/LockScreenLogo.scale-150.png"
                },
                new IconRegistration
                {
                    Height = 48,
                    Width = 48,
                    ProjectPath = "Assets/LockScreenLogo.scale-200.png"
                },
                new IconRegistration
                {
                    Height = 96,
                    Width = 96,
                    ProjectPath = "Assets/LockScreenLogo.scale-400.png"
                },
                new IconRegistration
                {
                    Height = 44,
                    Width = 44,
                    ProjectPath = "Assets/Square44x44Logo.scale-100.png"
                },
                new IconRegistration
                {
                    Height = 55,
                    Width = 55,
                    ProjectPath = "Assets/Square44x44Logo.scale-125.png"
                },
                new IconRegistration
                {
                    Height = 66,
                    Width = 66,
                    ProjectPath = "Assets/Square44x44Logo.scale-150.png"
                },
                new IconRegistration
                {
                    Height = 88,
                    Width = 88,
                    ProjectPath = "Assets/Square44x44Logo.scale-200.png"
                },
                new IconRegistration
                {
                    Height = 176,
                    Width = 176,
                    ProjectPath = "Assets/Square44x44Logo.scale-400.png"
                },
                new IconRegistration
                {
                    Height = 16,
                    Width = 16,
                    ProjectPath = "Assets/Square44x44Logo.targetsize-16_altform-unplated.png"
                },
                new IconRegistration
                {
                    Height = 24,
                    Width = 24,
                    ProjectPath = "Assets/Square44x44Logo.targetsize-24_altform-unplated.png"
                },
                new IconRegistration
                {
                    Height = 32,
                    Width = 32,
                    ProjectPath = "Assets/Square44x44Logo.targetsize-32_altform-unplated.png"
                },
                new IconRegistration
                {
                    Height = 48,
                    Width = 48,
                    ProjectPath = "Assets/Square44x44Logo.targetsize-48_altform-unplated.png"
                },
                new IconRegistration
                {
                    Height = 256,
                    Width = 256,
                    ProjectPath = "Assets/Square44x44Logo.targetsize-256_altform-unplated.png"
                },
                new IconRegistration
                {
                    Height = 150,
                    Width = 150,
                    ProjectPath = "Assets/Square150x150Logo.scale-100.png"
                },
                new IconRegistration
                {
                    Height = 188,
                    Width = 188,
                    ProjectPath = "Assets/Square150x150Logo.scale-125.png"
                },
                new IconRegistration
                {
                    Height = 225,
                    Width = 225,
                    ProjectPath = "Assets/Square150x150Logo.scale-150.png"
                },
                new IconRegistration
                {
                    Height = 300,
                    Width = 300,
                    ProjectPath = "Assets/Square150x150Logo.scale-200.png"
                },
                new IconRegistration
                {
                    Height = 600,
                    Width = 600,
                    ProjectPath = "Assets/Square150x150Logo.scale-400.png"
                },
                new IconRegistration
                {
                    Height = 50,
                    Width = 50,
                    ProjectPath = "Assets/StoreLogo.png"
                },
            };
        }
    }
}
