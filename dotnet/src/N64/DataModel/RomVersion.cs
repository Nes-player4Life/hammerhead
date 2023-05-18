using System.Globalization;
using System.Text.RegularExpressions;

namespace LibreShark.Hammerhead.N64;

public enum Brand
{
    UNKNOWN,
    GAMESHARK,
    ACTION_REPLAY,
    EQUALIZER,
    GAME_BUSTER,
    PERFECT_TRAINER,
    LIBRESHARK,
}

public static class BrandExtensions
{
    public static string ToFriendlyString(this Brand brand)
    {
        switch (brand)
        {
            case Brand.GAMESHARK:
                return "GameShark";
            case Brand.ACTION_REPLAY:
                return "Action Replay";
            case Brand.EQUALIZER:
                return "Equalizer";
            case Brand.GAME_BUSTER:
                return "Game Buster";
            case Brand.PERFECT_TRAINER:
                return "Perfect Trainer";
            case Brand.LIBRESHARK:
                return "LibreShark";
            default:
                return "UNKNOWN";
        }
    }
}

public partial class RomVersion
{
    public static readonly CultureInfo ENGLISH_US = CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
    public static readonly CultureInfo ENGLISH_UK = CultureInfo.GetCultureInfoByIetfLanguageTag("en-GB");
    public static readonly CultureInfo GERMAN_GERMANY = CultureInfo.GetCultureInfoByIetfLanguageTag("de-DE");
    public static readonly CultureInfo UNKNOWN_LOCALE = CultureInfo.InvariantCulture;

    public readonly string RawTimestamp;
    public readonly double Number;
    public readonly string? Disambiguator;
    public readonly DateTime BuildTimestamp;
    public readonly Brand Brand;
    public readonly CultureInfo Locale;

    public string? RawTitleVersionNumber { get; private set; }
    public double? ParsedTitleVersionNumber => RawTitleVersionNumber != null ? double.Parse(RawTitleVersionNumber) : null;

    public bool HasDisambiguator => !string.IsNullOrEmpty(Disambiguator);
    public string DisplayBrand => Brand.ToFriendlyString();
    public string DisplayNumber => HasDisambiguator ? $"v{Number:F2} ({Disambiguator})" : $"v{Number:F2}";
    public string DisplayBuildTimestampIso => BuildTimestamp.ToString("yyyy-MM-ddTHH:mm");
    public string DisplayBuildTimestampRaw => RawTimestamp;
    public string DisplayLocale => Locale.ToString();

    private RomVersion(string raw, double number, string? disambiguator, DateTime buildTimestamp, Brand brand, CultureInfo locale)
    {
        RawTimestamp = raw;
        Number = number;
        Disambiguator = disambiguator;
        BuildTimestamp = buildTimestamp;
        Brand = brand;
        Locale = locale;
    }

    public static RomVersion? From(string raw)
    {
        return KnownVersion(raw) ?? UnknownVersion(raw);
    }

    private static RomVersion Of(string raw, double number, string? disambiguator, DateTime buildTimestamp)
    {
        return new RomVersion(raw, number, disambiguator, buildTimestamp, Brand.UNKNOWN, UNKNOWN_LOCALE);
    }

    private static RomVersion Of(string raw, double number, string? disambiguator,
        int year, int month, int day, int hour, int minute, int second, Brand brand, CultureInfo locale)
    {
        return new RomVersion(raw, number, disambiguator, new DateTime(year, month, day, hour, minute, second), brand, locale);
    }

    private static RomVersion? KnownVersion(string raw)
    {
        // TODO: Find a v2.20 ROM and add its build timestamp here
        return raw.Trim() switch
        {
            // Action Replay
            "14:56 Apr 15 98" => Of(raw, 1.11, null,       1998, 04, 15, 14, 56, 00, Brand.ACTION_REPLAY, ENGLISH_UK),
            "15:50 Mar 24 99" => Of(raw, 3.00, null,       1999, 03, 24, 15, 50, 00, Brand.ACTION_REPLAY, ENGLISH_UK),
            "16:08 Apr 18"    => Of(raw, 3.30, null,       2000, 04, 18, 16, 08, 00, Brand.ACTION_REPLAY, ENGLISH_UK),

            // GameShark
            "12:50 Aug 1 97"  => Of(raw, 1.02, null,       1997, 08, 01, 12, 50, 00, Brand.GAMESHARK, ENGLISH_US),
            "10:35 Aug 19 97" => Of(raw, 1.04, null,       1997, 08, 19, 10, 35, 00, Brand.GAMESHARK, ENGLISH_US),
            "16:25 Sep 4 97"  => Of(raw, 1.05, "Thursday", 1997, 09, 04, 16, 25, 00, Brand.GAMESHARK, ENGLISH_US),
            "13:51 Sep 5 97"  => Of(raw, 1.05, "Friday",   1997, 09, 05, 13, 51, 00, Brand.GAMESHARK, ENGLISH_US),
            "14:25 Sep 19 97" => Of(raw, 1.06, null,       1997, 09, 19, 14, 25, 00, Brand.GAMESHARK, ENGLISH_US),
            "17:21 Oct 27 97" => Of(raw, 1.07, "October",  1997, 10, 27, 17, 21, 00, Brand.GAMESHARK, ENGLISH_US),
            "10:24 Nov 7 97"  => Of(raw, 1.07, "November", 1997, 11, 07, 10, 24, 00, Brand.GAMESHARK, ENGLISH_US),
            "11:58 Nov 24 97" => Of(raw, 1.08, "November", 1997, 11, 24, 11, 58, 00, Brand.GAMESHARK, ENGLISH_US),
            "11:10 Dec 8 97"  => Of(raw, 1.08, "December", 1997, 12, 08, 11, 10, 00, Brand.GAMESHARK, ENGLISH_US),
            "17:40 Jan 5 98"  => Of(raw, 1.09, null,       1998, 01, 05, 17, 40, 00, Brand.GAMESHARK, ENGLISH_US),
            "08:06 Mar 5 98"  => Of(raw, 2.00, "March",    1998, 03, 05, 08, 06, 00, Brand.GAMESHARK, ENGLISH_US),
            "10:05 Apr 6 98"  => Of(raw, 2.00, "April",    1998, 04, 06, 10, 05, 00, Brand.GAMESHARK, ENGLISH_US),
            "13:57 Aug 25 98" => Of(raw, 2.10, null,       1998, 08, 25, 13, 57, 00, Brand.GAMESHARK, ENGLISH_US),
            "12:47 Dec 18 98" => Of(raw, 2.21, null,       1998, 12, 18, 12, 47, 00, Brand.GAMESHARK, ENGLISH_US),
            // TODO: Confirm v2.5 build timestamp
            "12:58 May 4"     => Of(raw, 2.50, null,       1999, 05, 04, 12, 58, 00, Brand.GAMESHARK, ENGLISH_US),
            "15:05 Apr 1 99"  => Of(raw, 3.00, null,       1999, 04, 01, 15, 05, 00, Brand.GAMESHARK, ENGLISH_US),
            "16:50 Jun 9 99"  => Of(raw, 3.10, null,       1999, 06, 09, 16, 50, 00, Brand.GAMESHARK, ENGLISH_US),
            "18:45 Jun 22 99" => Of(raw, 3.20, null,       1999, 06, 22, 18, 45, 00, Brand.GAMESHARK, ENGLISH_US),
            "14:26 Jan 4"     => Of(raw, 3.21, null,       2000, 01, 04, 14, 26, 00, Brand.GAMESHARK, ENGLISH_US),
            "09:54 Mar 27"    => Of(raw, 3.30, "March",    2000, 03, 27, 09, 54, 00, Brand.GAMESHARK, ENGLISH_US),
            "15:56 Apr 4"     => Of(raw, 3.30, "April",    2000, 04, 04, 15, 56, 00, Brand.GAMESHARK, ENGLISH_US),

            // Equalizer (UK)
            // According to this, Equalizer was a "budget" version of the Action Replay, and was also sold in the UK:
            // https://www.reddit.com/r/n64/comments/t2hdsh/comment/hymp77l/
            "09:44 J5l 20 99" => Of(raw, 3.00, null,       1999, 07, 20, 09, 44, 00, Brand.EQUALIZER, ENGLISH_UK),

            // Game Buster (Germany)
            "11:09 Aug 5 99"  => Of(raw, 3.21, null,       1999, 08, 05, 11, 09, 00, Brand.GAME_BUSTER, GERMAN_GERMANY),

            // Trainers
            "2003 iCEMARi0"   => Of(raw, 1.00, "b",        2003, 06, 18, 00, 00, 00, Brand.PERFECT_TRAINER, ENGLISH_US),

            // Unknown
            _                 => null
        };
    }

    [GeneratedRegex("(?<HH>\\d\\d):(?<mm>\\d\\d) (?<MMM>\\w\\w\\w) (?<dd>\\d\\d?)(?: (?<yy>\\d\\d)?)?")]
    private static partial Regex TimestampRegex();

    private static RomVersion? UnknownVersion(string raw)
    {
        string trimmed = raw.Trim();
        var match = TimestampRegex().Match(trimmed);
        if (!match.Success)
        {
            Console.Error.WriteLine($"ERROR: Invalid GS ROM build timestamp: '{trimmed}'(len = {trimmed.Length}). Expected HH:mm MMM dd [yy].");
            return null;
        }

        var HH = match.Groups["HH"].Value;
        var mm = match.Groups["mm"].Value;
        var MMM = match.Groups["MMM"].Value;
        var dd = match.Groups["dd"].Value;

        // Equalizer vX.XX contains either a typo or corrupted data.
        // TODO(CheatoBaggins): Dump more Equalizer ROMs for comparison
        if (MMM == "J5l")
        {
            MMM = "Jul";
        }

        // Versions 2.5, 3.21, and 3.3 omit the year from the end of the timestamp.
        // We specifically handle those cases above, but we're still missing dumps of v1.01, v1.02, and v2.03.
        // The missing dumps were likely made in 1997, so we default to that.
        var yyyy = match.Groups["yy"].Success ? $"19{match.Groups["yy"].Value}" : "1997";

        trimmed = $"{HH}:{mm} {MMM} {dd} {yyyy}";
        if (!Is(trimmed, "HH:mm MMM d yyyy", out var timestamp))
        {
            Console.Error.WriteLine($"ERROR: Invalid GS ROM build timestamp: '{trimmed}' (len = {trimmed.Length}). Expected HH:mm MMM dd yyyy.");
            return null;
        }

        return Of(raw, 0.00, "UNKNOWN", timestamp);
    }

    private static bool Is(string rawDateTime, string dateTimeFormat, out DateTime datetime)
    {
        return DateTime.TryParseExact(rawDateTime, dateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out datetime);
    }

    public override string ToString()
    {
        return $"{Brand.ToFriendlyString()} v{Number:F2}" +
               (string.IsNullOrEmpty(Disambiguator) ? "" : $" ({Disambiguator})") +
               $", built on {BuildTimestamp:yyyy-MM-dd HH:mm} ('{RawTimestamp}') - {Locale}";
    }

    public RomVersion WithTitleVersionNumber(string? titleVersionStr)
    {
        RawTitleVersionNumber = titleVersionStr;
        return this;
    }
}
