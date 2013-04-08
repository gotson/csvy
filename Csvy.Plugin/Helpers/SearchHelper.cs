using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Csvy.Plugin.Helpers
{
    public static class SearchHelper
    {
        // Regexp used in FormatReplace
        private static Regex regexpTokenHeader = new Regex(@"%\b(.*?)\b%",RegexOptions.Compiled);
        private static Regex regexpTokenEnv = new Regex(@"\$env\(([\w-]+)\)", RegexOptions.Compiled);
        private static Regex regexpTokenIf = new Regex(@"\$if\((.*?),(.*?),(.*?)\)", RegexOptions.Compiled);
        private static Regex regexpTokenRegex = new Regex("\\$regex\\((.*),\"(.*)\",\"(.*)\"\\)", RegexOptions.Compiled);

        private static char[] escapes = new char[] { '\\', '+', '?', '|', '{', '[', '(', ')', '^', '$', '#' };

        /// <summary>
        /// Check if the needle is found in the haystack.
        /// The needle's components don't need to be adjacent.
        /// </summary>
        /// <param name="haystack">Haystack</param>
        /// <param name="needle">Needle</param>
        /// <returns>True if the search is successful</returns>
        public static bool ContainsAnywhere(string haystack, string needle)
        {
            return SearchHelper.ContainsAnywhere(haystack, needle, true);
        }

        /// <summary>
        /// Check if the needle is found in the haystack.
        /// The needle's components don't need to be adjacent.
        /// </summary>
        /// <param name="haystack">Haystack</param>
        /// <param name="needle">Needle</param>
        /// <param name="escape">If true, the standard regexp characters will be escaped</param>
        /// <returns>True if the search is successful</returns>
        public static bool ContainsAnywhere(string haystack, string needle, bool escape)
        {
            if (escape)
                return SearchHelper.ContainsAnywhere(haystack, needle, escapes);
            else
                return SearchHelper.ContainsAnywhere(haystack, needle, new char[0]);
        }

        /// <summary>
        /// Check if the needle is found in the haystack.
        /// The needle's components don't need to be adjacent.
        /// </summary>
        /// <param name="haystack">Haystack</param>
        /// <param name="needle">Needle</param>
        /// <param name="escapes">a list of characters to escape</param>
        /// <returns>True if the search is successful</returns>
        public static bool ContainsAnywhere(string haystack, string needle, char[] escapes)
        {
            //build regexp
            string pattern = ".*";
            haystack.Replace(" ","");
            foreach (char c in needle.ToCharArray())
            {
                pattern = string.Concat(pattern, c, ".*");
            }

            //manage characters to escape
            foreach (char c in escapes)
            {
                pattern = pattern.Replace(c.ToString(), @"\" + c);
            }

            Regex r = new Regex(pattern);

            return r.IsMatch(haystack);
        }

        /// <summary>
        /// Returns a string where the mask has been replaced by corresponding elements of the item
        /// </summary>
        /// <param name="mask">Mask</param>
        /// <param name="item">Item</param>
        /// <returns>Replaced mask</returns>
        public static string ReplaceMaskWithItem(string mask, DataRow item)
        {
            //replace mask
            string ret = regexpTokenHeader.Replace(mask, delegate(Match match)
            {
                try
                {
                    return item[match.Groups[1].Value].ToString();
                }
                catch (Exception)
                {
                    return match.Value;
                }
            });

            return ReplaceFunctions(ret, item);
        }

        /// <summary>
        /// Returns a string where the $FUNCTIONs have been replaced by their result
        /// </summary>
        /// <param name="mask">Mask string containing $FUNCTIONs</param>
        /// <param name="item">Item</param>
        /// <returns>Replaced string</returns>
        private static string ReplaceFunctions(string mask, DataRow item)
        {
            //replace $json
            return ReplaceFunctions(mask.Replace("$json", SerializationHelper.SerializeToJson(item)));
        }

        /// <summary>
        /// Returns a string where the $FUNCTIONs have been replaced by their result.
        /// This function doesn't replace $json, as the item is needed.
        /// </summary>
        /// <param name="mask">Mask string containing $FUNCTIONs</param>
        /// <returns>Replaced string</returns>
        private static string ReplaceFunctions(string mask)
        {
            string ret = mask;

            //replace $env(var)
            ret = regexpTokenEnv.Replace(ret, delegate(Match match)
            {
                try
                {
                    var env = Environment.GetEnvironmentVariable(match.Groups[1].Value);
                    if (string.IsNullOrEmpty(env))
                        return match.Value;
                    else
                        return env;
                }
                catch (Exception)
                {
                    return match.Value;
                }
            });

            //replace $regex(source,"regex","replacement")
            ret = regexpTokenRegex.Replace(ret, delegate(Match match)
            {
                try
                {
                    Regex r = new Regex(match.Groups[2].Value);
                    return r.Replace(match.Groups[1].Value, match.Groups[3].Value);
                }
                catch (Exception)
                {
                    return match.Value;
                }
            });

            //replace $if(condition,value1,value2)
            while (regexpTokenIf.IsMatch(ret))
            {
                ret = regexpTokenIf.Replace(ret, delegate(Match match)
                {
                    try
                    {
                        //if condition is empty, return value2, else return value1
                        if (string.IsNullOrEmpty(match.Groups[1].Value))
                            return match.Groups[3].Value;
                        else
                            return match.Groups[2].Value;
                    }
                    catch (Exception)
                    {
                        return match.Value;
                    }
                });
            }

            return ret;
        }
    }
}
