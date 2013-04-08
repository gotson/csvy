using System;
using System.Text.RegularExpressions;

namespace Csvy.Plugin.Helpers
{
    public static class FullPathHelper
    {
        /// <summary>
        /// Separator used in the item full path
        /// </summary>
        public const string SEPARATOR = "~";

        /// <summary>
        /// Available elements in a full path
        /// </summary>
        public enum FullPathElement { Referential, Item, Action };

        private static Regex regexFullPath = new Regex(@"([0-9]+)~(.*)~([0-9]*)", RegexOptions.Compiled);

        /// <summary>
        /// Build an element ID that can be used as an item full path
        /// </summary>
        /// <param name="referentialId">Referential hashcode</param>
        /// <param name="itemId">Item unique id</param>
        /// <returns>Unique element ID</returns>
        public static string BuildFullPath(string referentialId, string itemId)
        {
            return referentialId + SEPARATOR + itemId + SEPARATOR;
        }

        /// <summary>
        /// Build an element ID that can be used as an item full path
        /// </summary>
        /// <param name="referentialId">Referential hashcode</param>
        /// <param name="itemId">Item unique id</param>
        /// <param name="actionName">Action name</param>
        /// <returns>Unique element ID</returns>
        public static string BuildFullPath(string referentialId, string itemId, string actionId)
        {
            return BuildFullPath(referentialId, itemId) + actionId;
        }

        /// <summary>
        /// Parses a full path to retrieve a part of it
        /// </summary>
        /// <param name="fullPath">full path of the item</param>
        /// <param name="fullPathElement">element to retrieve</param>
        /// <returns>element value</returns>
        public static string ParseFullPath(string fullPath, FullPathElement fullPathElement)
        {
            int group = 0;
            switch (fullPathElement)
            {
                case FullPathElement.Referential:
                    group = 1;
                    break;
                case FullPathElement.Item:
                    group = 2;
                    break;
                case FullPathElement.Action:
                    group = 3;
                    break;
                default:
                    break;
            }

            if (group == 0)
                return string.Empty;

            try
            {
                return regexFullPath.Split(fullPath)[group];
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
