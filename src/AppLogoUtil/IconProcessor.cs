using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AppLogoUtil.Generators;

namespace AppLogoUtil
{
    public class IconProcessor : IIconProcessor
    {
        private IconGeneratorCollection _generators { get; } = new IconGeneratorCollection();

        public Dictionary<Platform, string> PlatformRegistrations { get; } = new Dictionary<Platform, string>();

        /// <summary>
        /// Adds the icon.
        /// </summary>
        /// <param name="path">Path of the Icon.</param>
        /// <param name="platforms">Platforms.</param>
        public void AddIcon(string path, params Platform[] platforms)
        {
            foreach (var platform in platforms)
                PlatformRegistrations.Add(platform, path);
        }

        /// <summary>
        /// Generates the icons.
        /// </summary>
        /// <param name="path">Path of the Platform Project.</param>
        /// <param name="platform">Platform.</param>
        public void GenerateIcons(string path, Platform platform)
        {
            var generator = PlatformGeneratorFactory.GetGenerator(platform);

            if (generator == null) return;

            var iconPath = (from pair in PlatformRegistrations
                            where pair.Key == platform ||
                            pair.Key == Platform.Any
                            select pair.Value).FirstOrDefault();

            generator.GenerateIcons(path, iconPath);
        }

        public IconStatus GetStatus(Platform platform)
        {
            string iconPath = null;

            if (PlatformRegistrations.ContainsKey(platform))
            {
                iconPath = PlatformRegistrations[platform];
            }
            else if (PlatformRegistrations.ContainsKey(Platform.Any))
            {
                iconPath = PlatformRegistrations[Platform.Any];
            }

            return _generators[platform].GetStatus(iconPath);
        }
    }
}
