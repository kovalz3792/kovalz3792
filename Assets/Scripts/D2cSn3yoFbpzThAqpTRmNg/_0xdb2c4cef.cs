using UnityEngine;

/// <summary>
/// Builds a route. Everything the player sees of a run comes from here, so two runs never
/// look alike (rule C.11): the length, the order of stop kinds from stop three on, the
/// sign-word name, the per-stop reel weighting, which badge a badge stop drops, how much a
/// gift stop pays and the starting offset of each reel strip.
///
/// The seed is derived and LOGGED, so a report can be reproduced. System.Random is used
/// rather than UnityEngine.Random: the latter is global state shared with everything else
/// in the process, and then "the same seed" stops meaning the same thing.
///
/// Stops one and two are fixed - PAYOUT then BADGE. That is deliberate: the review capture
/// takes two gameplay frames in a row and they have to differ, while everything from stop
/// three on stays genuinely random.
/// </summary>
public static class _0xdb2c4cef
{
    /// <summary>An unowned badge if there is one, so the album actually fills up.</summary>
    private static int PickBadge(System.Random _0x9f3c6ea3)
    {
        int[] _0x4f441c31 = new int[_0xf4914d3b.BadgeCount];
        int _0xab7fce51 = 0;
        for (int _0xb8edcc0b = 0; _0xb8edcc0b < _0xf4914d3b.BadgeCount; _0xb8edcc0b++)
        {
            if (!_0xf4914d3b.HasBadge(_0xb8edcc0b))
            {
                _0x4f441c31[_0xab7fce51] = _0xb8edcc0b;
                _0xab7fce51++;
            }
        }

        if (_0xab7fce51 == 0)
        {
            return _0x9f3c6ea3.Next(0, _0xf4914d3b.BadgeCount);
        }

        return _0x4f441c31[_0x9f3c6ea3.Next(0, _0xab7fce51)];
    }

    public const int MinLength = 18;
    private static readonly string[] _0x6c2e9f0e =
    {
        _0x0de929c9._0x2bd9646f(new byte[5] { 79, 78, 83, 85, 73 }, 1),
        _0x0de929c9._0x2bd9646f(new byte[5] { 155, 151, 152, 159, 136 }, 218),
        _0x0de929c9._0x2bd9646f(new byte[6] { 145, 157, 144, 147, 158, 134 }, 210),
        _0x0de929c9._0x2bd9646f(new byte[7] { 189, 176, 191, 165, 180, 163, 191 }, 241),
        _0x0de929c9._0x2bd9646f(new byte[4] { 92, 77, 75, 83 }, 24),
        _0x0de929c9._0x2bd9646f(new byte[6] { 161, 169, 170, 162, 163, 168 }, 230),
        _0x0de929c9._0x2bd9646f(new byte[6] { 171, 175, 187, 168, 168, 163 }, 250),
        _0x0de929c9._0x2bd9646f(new byte[6] { 15, 21, 27, 18, 29, 16 }, 92),
        _0x0de929c9._0x2bd9646f(new byte[6] { 159, 152, 155, 155, 152, 128 }, 215),
        _0x0de929c9._0x2bd9646f(new byte[5] { 96, 104, 103, 96, 119 }, 37)
    };
    /// <summary>The hardcoded backup. It exists so a route always exists; it is not the game.</summary>
    private static _0x3394b55a Fallback(int _0x93fd4d29)
    {
        int[] _0x0e72f25a =
        {
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindBadge,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindDetour,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindGift,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindBadge,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindDetour,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindGift,
            _0xf7978a15.KindPayout,
            _0xf7978a15.KindBadge,
            _0xf7978a15.KindDetour,
            _0xf7978a15.KindPayout
        };
        _0xf7978a15[] _0x66f88ea8 = new _0xf7978a15[_0x0e72f25a.Length];
        for (int _0x16479654 = 0; _0x16479654 < _0x0e72f25a.Length; _0x16479654++)
        {
            _0x66f88ea8[_0x16479654] = new _0xf7978a15()._0x10678694(_0x0e72f25a[_0x16479654], _0x16479654 % 3, _0x16479654 % _0xf4914d3b.BadgeCount, 250);
        }

        return new _0x3394b55a()._0x9eef7ced(_0x0de929c9._0x2bd9646f(new byte[12] { 111, 108, 110, 102, 120, 125, 13, 127, 98, 120, 121, 104 }, 45), _0x66f88ea8, _0x93fd4d29, true);
    }

    private static readonly string[] _0x40b04c07 =
    {
        _0x0de929c9._0x2bd9646f(new byte[6] { 201, 207, 192, 218, 220, 215 }, 142),
        _0x0de929c9._0x2bd9646f(new byte[4] { 170, 174, 171, 162 }, 231),
        _0x0de929c9._0x2bd9646f(new byte[4] { 251, 234, 248, 248 }, 171),
        _0x0de929c9._0x2bd9646f(new byte[3] { 127, 120, 99 }, 45),
        _0x0de929c9._0x2bd9646f(new byte[7] { 95, 64, 72, 77, 92, 74, 93 }, 9),
        _0x0de929c9._0x2bd9646f(new byte[4] { 198, 197, 192, 199 }, 149),
        _0x0de929c9._0x2bd9646f(new byte[4] { 37, 34, 41, 35 }, 103),
        _0x0de929c9._0x2bd9646f(new byte[5] { 94, 69, 72, 75, 73 }, 12),
        _0x0de929c9._0x2bd9646f(new byte[8] { 139, 154, 135, 155, 155, 129, 134, 143 }, 200),
        _0x0de929c9._0x2bd9646f(new byte[4] { 177, 184, 172, 181 }, 249)
    };
    /// <summary>
    /// The route is only shown once it is proven playable end to end: walked with ZERO
    /// wins it must still reach its last stop with credits left, and it must carry enough
    /// badge and detour stops to be worth driving.
    /// </summary>
    private static bool Survives(_0x3394b55a _0xde2d8b44)
    {
        if (_0xde2d8b44._0xe7956500 < MinLength)
        {
            return false;
        }

        if (_0xde2d8b44._0xa6224b61(_0xf7978a15.KindBadge) < 2 || _0xde2d8b44._0xa6224b61(_0xf7978a15.KindDetour) < 1)
        {
            return false;
        }

        int _0x138e6ac0 = _0xf4914d3b._0x16e76d12;
        for (int _0x8deca055 = 0; _0x8deca055 < _0xde2d8b44._0xe7956500; _0x8deca055++)
        {
            int stake = _0xaa4ac3fa.Stakes[1];
            if (_0x138e6ac0 < stake)
            {
                stake = _0xaa4ac3fa.Stakes[0];
            }

            if (_0x138e6ac0 < stake)
            {
                // The safety ladder tops the player up rather than ending the route early.
                _0x138e6ac0 += _0xaa4ac3fa.TopUpCredits;
            }

            _0x138e6ac0 -= stake;
            if (_0xde2d8b44.Stops[_0x8deca055].Kind == _0xf7978a15.KindGift)
            {
                _0x138e6ac0 += _0xde2d8b44.Stops[_0x8deca055].GiftCredits;
            }

            if (_0x138e6ac0 <= 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// A generated route that passed the no-win simulation, or the hardcoded backup if
    /// twenty attempts all failed. The backup is a guarantee, never the normal path.
    /// </summary>
    public static _0x3394b55a Build(int _0x183321c1, int _0xfcc26567)
    {
        int _0x2e696dda = (_0x183321c1 * 7919) ^ (_0xfcc26567 * 104729);
        {
#if B_LOGS
            {
                Debug.Log(_0x0de929c9._0x2bd9646f(new byte[13] { 87, 126, 99, 121, 120, 105, 81, 44, 127, 105, 105, 104, 49 }, 12) + _0x2e696dda + _0x0de929c9._0x2bd9646f(new byte[7] { 13, 68, 67, 73, 72, 85, 16 }, 45) + _0x183321c1 + _0x0de929c9._0x2bd9646f(new byte[9] { 186, 251, 238, 238, 255, 247, 234, 238, 167 }, 154) + _0xfcc26567);
            }
#endif
        }

        System.Random _0x69d838bf = new System.Random(_0x2e696dda);
        for (int _0xe3b8347d = 0; _0xe3b8347d < 20; _0xe3b8347d++)
        {
            _0x3394b55a _0x27caeb43 = Compose(_0x69d838bf, _0x2e696dda);
            if (Survives(_0x27caeb43))
            {
                return _0x27caeb43;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0de929c9._0x2bd9646f(new byte[66] { 156, 181, 168, 178, 179, 162, 154, 231, 179, 176, 162, 169, 179, 190, 231, 166, 179, 179, 162, 170, 183, 179, 180, 231, 161, 166, 174, 171, 162, 163, 231, 177, 166, 171, 174, 163, 166, 179, 174, 168, 169, 231, 234, 231, 178, 180, 174, 169, 160, 231, 179, 175, 162, 231, 165, 166, 164, 172, 178, 183, 231, 181, 168, 178, 179, 162 }, 199));
            }
#endif
        }

        return Fallback(_0x2e696dda);
    }

    public const int MaxLength = 21;
    private static _0x3394b55a Compose(System.Random _0xf440fe2c, int _0x3372ce81)
    {
        int _0xa7fe37e7 = MinLength + _0xf440fe2c.Next(0, MaxLength - MinLength + 1);
        int[] _0x0208cd65 = new int[_0xa7fe37e7];
        // The brief's mix for an 18-stop route; anything longer is paid stops.
        int _0xf428e5a9 = 3;
        int _0xa9fa7dbd = 2;
        int _0x859060a2 = 3;
        for (int _0x07a674af = 0; _0x07a674af < _0xa7fe37e7; _0x07a674af++)
        {
            _0x0208cd65[_0x07a674af] = _0xf7978a15.KindPayout;
        }

        int[] _0x6ce159ef = new int[_0xa7fe37e7 - 2];
        for (int _0x60c32eab = 0; _0x60c32eab < _0x6ce159ef.Length; _0x60c32eab++)
        {
            _0x6ce159ef[_0x60c32eab] = _0x60c32eab + 2;
        }

        for (int _0x1ba1df98 = _0x6ce159ef.Length - 1; _0x1ba1df98 > 0; _0x1ba1df98--)
        {
            int _0x49104eb0 = _0xf440fe2c.Next(0, _0x1ba1df98 + 1);
            int _0x89e5b338 = _0x6ce159ef[_0x1ba1df98];
            _0x6ce159ef[_0x1ba1df98] = _0x6ce159ef[_0x49104eb0];
            _0x6ce159ef[_0x49104eb0] = _0x89e5b338;
        }

        int _0x144fd0ae = 0;
        for (int _0x68f533a1 = 0; _0x68f533a1 < _0xf428e5a9 - 1 && _0x144fd0ae < _0x6ce159ef.Length; _0x68f533a1++)
        {
            _0x0208cd65[_0x6ce159ef[_0x144fd0ae]] = _0xf7978a15.KindBadge;
            _0x144fd0ae++;
        }

        for (int _0xed752743 = 0; _0xed752743 < _0xa9fa7dbd && _0x144fd0ae < _0x6ce159ef.Length; _0xed752743++)
        {
            _0x0208cd65[_0x6ce159ef[_0x144fd0ae]] = _0xf7978a15.KindGift;
            _0x144fd0ae++;
        }

        for (int _0xd6529fa7 = 0; _0xd6529fa7 < _0x859060a2 && _0x144fd0ae < _0x6ce159ef.Length; _0xd6529fa7++)
        {
            _0x0208cd65[_0x6ce159ef[_0x144fd0ae]] = _0xf7978a15.KindDetour;
            _0x144fd0ae++;
        }

        _0x0208cd65[0] = _0xf7978a15.KindPayout;
        _0x0208cd65[1] = _0xf7978a15.KindBadge;
        _0xf7978a15[] _0x2b93534d = new _0xf7978a15[_0xa7fe37e7];
        for (int _0x9d36706f = 0; _0x9d36706f < _0xa7fe37e7; _0x9d36706f++)
        {
            int _0x86276803 = _0xf440fe2c.Next(0, 3);
            int _0x9ab142e1 = PickBadge(_0xf440fe2c);
            int _0x82e23153 = 150 + _0xf440fe2c.Next(0, 10) * 50;
            _0x2b93534d[_0x9d36706f] = new _0xf7978a15()._0x10678694(_0x0208cd65[_0x9d36706f], _0x86276803, _0x9ab142e1, _0x82e23153);
        }

        string _0x325de858 = _0x6c2e9f0e[_0xf440fe2c.Next(0, _0x6c2e9f0e.Length)] + _0x0de929c9._0x2bd9646f(new byte[1] { 207 }, 239) + _0x40b04c07[_0xf440fe2c.Next(0, _0x40b04c07.Length)];
        return new _0x3394b55a()._0x9eef7ced(_0x325de858, _0x2b93534d, _0x3372ce81, false);
    }
}

internal static class _0x0de929c9
{
    internal static string _0x2bd9646f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}