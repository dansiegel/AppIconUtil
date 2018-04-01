using System;
namespace AppIconUtil.Generators
{
    public interface IPlatformIconGenerator
    {
        void GenerateIcons(string projectPath, string iconPath);

        IconStatus GetStatus();

        IconStatus GetStatus(string iconPath);
    }
}
