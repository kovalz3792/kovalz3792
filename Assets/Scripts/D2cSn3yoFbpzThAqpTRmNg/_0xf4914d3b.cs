using UnityEngine;

/// <summary>
/// Local persistence. Every key is a STABLE string literal that does not depend on a C#
/// name: the obfuscator renames classes, fields and methods, and a saved profile has to
/// survive that.
///
/// Credits are mirrored into SETTINGS.PlayerSYSTEM.Coins so the template MoneyCount
/// readouts agree with this game's credit rail.
/// </summary>
public static class _0xf4914d3b
{
    public static int _0x14c4bbdd
    {
        get
        {
            return PlayerPrefs.GetInt(KeyStreak, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyStreak, value);
        }
    }

    private static readonly string KeyStreak = _0x24d300e6._0x5296e133(new byte[9] { 25, 22, 84, 9, 14, 8, 31, 27, 17 }, 122);
    public static long _0xcc22e047
    {
        get
        {
            string _0x3ef3366d = PlayerPrefs.GetString(KeyGift, _0x24d300e6._0x5296e133(new byte[1] { 190 }, 142));
            long _0xf87771a8;
            return long.TryParse(_0x3ef3366d, out _0xf87771a8) ? _0xf87771a8 : 0L;
        }

        set
        {
            PlayerPrefs.SetString(KeyGift, value.ToString());
        }
    }

    private static readonly string KeyDecor = _0x24d300e6._0x5296e133(new byte[12] { 159, 144, 210, 152, 153, 159, 147, 142, 210, 143, 153, 136 }, 252);
    public static int MissionProgress(int _0x1cb5868b)
    {
        return PlayerPrefs.GetInt(KeyMissionProgress + _0x1cb5868b, 0);
    }

    private static readonly string KeyRoutes = _0x24d300e6._0x5296e133(new byte[17] { 178, 189, 255, 163, 190, 164, 165, 180, 162, 255, 178, 189, 180, 176, 163, 180, 181 }, 209);
    public static void SetMissionProgress(int _0x599d6d35, int _0x1d9b69e2)
    {
        PlayerPrefs.SetInt(KeyMissionProgress + _0x599d6d35, _0x1d9b69e2 < 0 ? 0 : _0x1d9b69e2);
    }

    public static bool _0x570a1891
    {
        get
        {
            return PlayerPrefs.GetInt(KeyReduceMotion, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyReduceMotion, value ? 1 : 0);
        }
    }

    public static void ResetAll()
    {
        PlayerPrefs.DeleteKey(KeyBadges);
        PlayerPrefs.DeleteKey(KeyRoutes);
        PlayerPrefs.DeleteKey(KeySpins);
        PlayerPrefs.DeleteKey(KeyBest);
        PlayerPrefs.DeleteKey(KeyStreak);
        PlayerPrefs.DeleteKey(KeyGift);
        PlayerPrefs.DeleteKey(KeyMissionDay);
        PlayerPrefs.DeleteKey(KeyDecor);
        for (int _0x3c73c44f = 0; _0x3c73c44f < 3; _0x3c73c44f++)
        {
            PlayerPrefs.DeleteKey(KeyMissionProgress + _0x3c73c44f);
        }

        _0x16e76d12 = StartingCredits;
    }

    public static bool HasBadge(int _0x84c506e2)
    {
        return (_0x33bf0281 & (1 << _0x84c506e2)) != 0;
    }

    private static readonly string KeyHighContrast = _0x24d300e6._0x5296e133(new byte[19] { 46, 33, 99, 34, 61, 57, 99, 37, 36, 42, 37, 14, 34, 35, 57, 63, 44, 62, 57 }, 77);
    public static void GrantBadge(int _0xb8848a56)
    {
        _0x33bf0281 = _0x33bf0281 | (1 << _0xb8848a56);
    }

    public static int _0x51ab4991
    {
        get
        {
            return PlayerPrefs.GetInt(KeyDecor, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyDecor, value);
        }
    }

    public static int _0xf107532a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyRoutes, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyRoutes, value);
        }
    }

    public static int OwnedBadges()
    {
        int _0xde73722a = _0x33bf0281;
        int _0xfcf218b1 = 0;
        for (int _0x837e3e49 = 0; _0x837e3e49 < BadgeCount; _0x837e3e49++)
        {
            if ((_0xde73722a & (1 << _0x837e3e49)) != 0)
            {
                _0xfcf218b1++;
            }
        }

        return _0xfcf218b1;
    }

    private static readonly string KeySpins = _0x24d300e6._0x5296e133(new byte[8] { 197, 202, 136, 213, 214, 207, 200, 213 }, 166);
    private static readonly string KeyBest = _0x24d300e6._0x5296e133(new byte[14] { 179, 188, 254, 178, 181, 163, 164, 254, 160, 177, 169, 191, 165, 164 }, 208);
    public static int _0xfd792853
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBest, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBest, value);
        }
    }

    public static int _0x16e76d12
    {
        get
        {
            if (!PlayerPrefs.HasKey(KeySeeded))
            {
                PlayerPrefs.SetInt(KeySeeded, 1);
                PlayerPrefs.SetInt(KeyCredits, StartingCredits);
            }

            return PlayerPrefs.GetInt(KeyCredits, StartingCredits);
        }

        set
        {
            int _0x9b6f6963 = value < 0 ? 0 : value;
            PlayerPrefs.SetInt(KeySeeded, 1);
            PlayerPrefs.SetInt(KeyCredits, _0x9b6f6963);
            _0x7d9c5f21._0x2ad08372._0xa3be3a7a = _0x9b6f6963;
        }
    }

    public const int BadgeCount = 12;
    private static readonly string KeyGift = _0x24d300e6._0x5296e133(new byte[17] { 13, 2, 64, 9, 7, 8, 26, 64, 2, 15, 29, 26, 43, 30, 1, 13, 6 }, 110);
    public static bool _0x646fff08
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHighContrast, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHighContrast, value ? 1 : 0);
        }
    }

    private static readonly string KeyMissionDay = _0x24d300e6._0x5296e133(new byte[15] { 43, 36, 102, 37, 33, 59, 59, 33, 39, 38, 59, 102, 44, 41, 49 }, 72);
    private static readonly string KeyCredits = _0x24d300e6._0x5296e133(new byte[10] { 53, 58, 120, 53, 36, 51, 50, 63, 34, 37 }, 86);
    private static readonly string KeyReduceMotion = _0x24d300e6._0x5296e133(new byte[19] { 148, 155, 217, 152, 135, 131, 217, 133, 146, 147, 130, 148, 146, 186, 152, 131, 158, 152, 153 }, 247);
    public static int _0xecd6f2a5
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMissionDay, -1);
        }

        set
        {
            PlayerPrefs.SetInt(KeyMissionDay, value);
        }
    }

    public const int StartingCredits = 2500;
    private static readonly string KeyMissionProgress = _0x24d300e6._0x5296e133(new byte[20] { 206, 193, 131, 192, 196, 222, 222, 196, 194, 195, 222, 131, 221, 223, 194, 202, 223, 200, 222, 222 }, 173);
    public static string Money(int _0x50c70871)
    {
        return _0x50c70871.ToString(_0x24d300e6._0x5296e133(new byte[2] { 155, 229 }, 213), System.Globalization.CultureInfo.InvariantCulture);
    }

    private static readonly string KeyBadges = _0x24d300e6._0x5296e133(new byte[14] { 35, 44, 110, 34, 33, 36, 39, 37, 51, 110, 45, 33, 51, 43 }, 64);
    private static readonly string KeySeeded = _0x24d300e6._0x5296e133(new byte[9] { 89, 86, 20, 73, 95, 95, 94, 95, 94 }, 58);
    public static int _0x33bf0281
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBadges, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBadges, value);
        }
    }

    public static int _0x2a892773
    {
        get
        {
            return PlayerPrefs.GetInt(KeySpins, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeySpins, value);
        }
    }
}

internal static class _0x24d300e6
{
    internal static string _0x5296e133(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}