using System;
namespace AppLogoUtil.Generators
{
    public interface IPlatformIconGenerator
    {
        void GenerateIcons(string projectPath, string iconPath);

        IconStatus GetStatus();

        IconStatus GetStatus(string iconPath);
    }
}
