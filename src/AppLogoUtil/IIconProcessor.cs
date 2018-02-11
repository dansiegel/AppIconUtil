using System;
namespace AppLogoUtil
{
    public interface IIconProcessor
    {
        IconStatus GetStatus(Platform platform);

        void AddIcon(string path, params Platform[] platforms);

        void GenerateIcons(string path, Platform platform);
    }
}
