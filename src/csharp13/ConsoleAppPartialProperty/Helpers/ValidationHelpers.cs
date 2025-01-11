using System.Text.RegularExpressions;

namespace ConsoleAppPartialProperty.Helpers;

public static partial class ValidationHelpers
{
    [GeneratedRegex("sqlserver|postgres|mysql")]
    public static partial Regex IsRelationalDatabase { get; }
}
