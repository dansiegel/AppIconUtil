namespace AppIconUtil.Generators
{
    public struct PlatformGeneratorFactory
    {
        internal static IPlatformIconGenerator GetGenerator(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return new AndroidIconGenerator();
                case Platform.iOS:
                    return new iOSIconGenerator();
                case Platform.UWP:
                    return new UWPIconGenerator();
                default:
                    return null;
            }
        }
    }
}
