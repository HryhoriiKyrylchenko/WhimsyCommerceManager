using System.Text.RegularExpressions;

namespace Whimsy_WebAPI.Utilities
{
    public static partial class VersionValidator
    {
        private static readonly Regex _versionRegex = VersionRegex();

        public static bool IsValidVersionFormat(string version)
        {
            if (string.IsNullOrEmpty(version)) return false;
            return _versionRegex.IsMatch(version);
        }

        [GeneratedRegex(@"^\d+\.\d+\.\d+$")]
        private static partial Regex VersionRegex();
    }
}
