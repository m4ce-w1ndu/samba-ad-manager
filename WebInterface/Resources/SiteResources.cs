using System.CodeDom.Compiler;
using Microsoft.Extensions.Localization;

namespace WebInterface.Resources
{
    /// <summary>
    /// Site localized resources
    /// </summary>
    [GeneratedCode("", "")]
    public class SiteResources : IStringLocalizer
    {
        private readonly IStringLocalizer localizer;

        public LocalizedString this[string name] => localizer[name];

        public LocalizedString this[string name, params object[] arguments] => localizer[name, arguments];

        public LocalizedString GetString(string name) => localizer[name];

        public LocalizedString GetString(string name, params object[] arguments) => localizer[name, arguments];

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return localizer.GetAllStrings(includeParentCultures);
        }

        public SiteResources(IStringLocalizerFactory factory)
        {
            localizer = factory.Create(typeof(SiteResources));
        }
    }
}
