using UnityEngine;

/// <summary>
/// Three rotating daily missions. Which three, and in which order, comes from the day
/// number, so the set really changes instead of being the same list forever.
/// Progress is local and free; the reward is credits that cannot be bought or cashed out.
/// </summary>
public static class _0x6ab3f9d5
{
    public static int Reward(int _0x044857dc)
    {
        return _0x99747862[DefinitionFor(_0x044857dc)];
    }

    public static bool IsComplete(int _0xd6c9eeb7)
    {
        return Progress(_0xd6c9eeb7) >= Target(_0xd6c9eeb7);
    }

    private static readonly int[] _0x99747862 =
    {
        300,
        400,
        350,
        250,
        200,
        400
    };
    public static int Progress(int _0x82d7e530)
    {
        return _0xf4914d3b.MissionProgress(_0x82d7e530);
    }

    public static int Today()
    {
        return (int)(System.DateTime.UtcNow.Ticks / System.TimeSpan.TicksPerDay);
    }

    public const int Slots = 3;
    public static void ReportRouteCleared(int _0xf8972a0d)
    {
        EnsureToday();
        for (int _0xf5723e26 = 0; _0xf5723e26 < Slots; _0xf5723e26++)
        {
            int _0x8758d545 = DefinitionFor(_0xf5723e26);
            if (_0x8758d545 == 1)
            {
                Advance(_0xf5723e26, 1);
            }
            else if (_0x8758d545 == 2)
            {
                Advance(_0xf5723e26, _0xf8972a0d);
            }
        }
    }

    private static readonly string[] _0x41e008c7 =
    {
        _0xe79c1f80._0xcb6b3ac4(new byte[13] { 88, 91, 66, 69, 43, 58, 62, 43, 88, 95, 68, 91, 88 }, 11),
        _0xe79c1f80._0xcb6b3ac4(new byte[13] { 172, 163, 170, 174, 189, 207, 174, 207, 189, 160, 186, 187, 170 }, 239),
        _0xe79c1f80._0xcb6b3ac4(new byte[16] { 56, 52, 55, 55, 62, 56, 47, 91, 73, 91, 57, 58, 63, 60, 62, 40 }, 123),
        _0xe79c1f80._0xcb6b3ac4(new byte[15] { 134, 139, 132, 142, 234, 249, 234, 154, 139, 147, 134, 131, 132, 143, 153 }, 202),
        _0xe79c1f80._0xcb6b3ac4(new byte[13] { 141, 152, 146, 156, 249, 152, 249, 157, 156, 141, 150, 140, 139 }, 217),
        _0xe79c1f80._0xcb6b3ac4(new byte[17] { 20, 23, 24, 29, 118, 100, 102, 102, 102, 118, 21, 4, 19, 18, 31, 2, 5 }, 86)
    };
    /// <summary>Rolls a fresh set when the day turns. Safe to call as often as you like.</summary>
    public static void EnsureToday()
    {
        int _0x9aa50da4 = Today();
        if (_0xf4914d3b._0xecd6f2a5 == _0x9aa50da4)
        {
            return;
        }

        _0xf4914d3b._0xecd6f2a5 = _0x9aa50da4;
        for (int _0x05d90630 = 0; _0x05d90630 < Slots; _0x05d90630++)
        {
            _0xf4914d3b.SetMissionProgress(_0x05d90630, 0);
        }
    }

    public static void Advance(int _0x8ef84e0f, int _0x1b80f26a)
    {
        _0xf4914d3b.SetMissionProgress(_0x8ef84e0f, Progress(_0x8ef84e0f) + _0x1b80f26a);
    }

    private static readonly int[] _0x2e8d8f65 =
    {
        15,
        1,
        2,
        3,
        1,
        2000
    };
    public static int Target(int _0xc2c9cbb9)
    {
        return _0x2e8d8f65[DefinitionFor(_0xc2c9cbb9)];
    }

    public static string Title(int _0x703ffb2a)
    {
        return _0x41e008c7[DefinitionFor(_0x703ffb2a)];
    }

    /// <summary>Called by the game scene after a spin so the lobby rows really move.</summary>
    public static void ReportSpin(int _0xc0177571, int _0x86408c6c, bool _0x26921024)
    {
        EnsureToday();
        for (int _0xb80b6cb5 = 0; _0xb80b6cb5 < Slots; _0xb80b6cb5++)
        {
            int _0x9c765dae = DefinitionFor(_0xb80b6cb5);
            if (_0x9c765dae == 0)
            {
                Advance(_0xb80b6cb5, 1);
            }
            else if (_0x9c765dae == 3 && _0x86408c6c >= 3)
            {
                Advance(_0xb80b6cb5, 1);
            }
            else if (_0x9c765dae == 4 && _0x26921024)
            {
                Advance(_0xb80b6cb5, 1);
            }
            else if (_0x9c765dae == 5 && _0xc0177571 > 0)
            {
                Advance(_0xb80b6cb5, _0xc0177571);
            }
        }
    }

    public static int DefinitionFor(int _0x81e107c2)
    {
        int _0x13bfaa12 = _0xf4914d3b._0xecd6f2a5 < 0 ? Today() : _0xf4914d3b._0xecd6f2a5;
        return (_0x13bfaa12 * 7 + _0x81e107c2 * 3) % _0x41e008c7.Length;
    }
}

internal static class _0xe79c1f80
{
    internal static string _0xcb6b3ac4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}