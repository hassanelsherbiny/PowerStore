using PowerStore.Core.Plugins;
using System.Collections.Generic;

namespace PowerStore.Framework.Themes
{
    public partial interface IThemeProvider
    {
        ThemeConfiguration GetThemeConfiguration(string themeName);

        IList<ThemeConfiguration> GetThemeConfigurations();

        bool ThemeConfigurationExists(string themeName);

        ThemeDescriptor GetThemeDescriptorFromText(string text);
    }
}
