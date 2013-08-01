using System.Linq;

namespace Umbraco.Core.Services
{
    public static class ContentServiceExtensions
    {
        /// <summary>
        /// Returns true if there is any content in the recycle bin
        /// </summary>
        /// <param name="contentService"></param>
        /// <returns></returns>
        public static bool RecycleBinSmells(this IContentService contentService)
        {
            return contentService.GetContentInRecycleBin().Any();
        }
    }
}