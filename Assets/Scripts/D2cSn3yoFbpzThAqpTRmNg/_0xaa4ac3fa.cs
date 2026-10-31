/// <summary>
/// The reel maths: five weighted symbols, three columns of three, five paylines (the three
/// rows and the two diagonals). Pure logic - it knows nothing about the view, so the whole
/// paytable can be simulated offline.
///
/// Symbols are indices 0..4 and the art behind them is interchangeable by contract, so the
/// game speaks in indices and the board decides which picture goes with which index.
/// </summary>
public static class _0xaa4ac3fa
{
    /// <summary>Evaluates the five paylines and reports what each one paid.</summary>
    public static _0x45fae2d6 Evaluate(int[] _0x20aa5600, int stake, float _0x89a61012)
    {
        bool[] _0x68c8645b = new bool[Columns * Rows];
        int _0xa491bc16 = 0;
        int _0x5a1da9d9 = 0;
        int _0xf027dd9c = -1;
        float _0x91d73237 = 0f;
        for (int _0xa3ddc956 = 0; _0xa3ddc956 < LineCount; _0xa3ddc956++)
        {
            int _0x2ea18c16 = _0x5ca6402e[_0xa3ddc956 * 3];
            int _0x3e20b776 = _0x5ca6402e[_0xa3ddc956 * 3 + 1];
            int _0x472384ee = _0x5ca6402e[_0xa3ddc956 * 3 + 2];
            float _0x04e05960 = 0f;
            if (_0x20aa5600[_0x2ea18c16] == _0x20aa5600[_0x3e20b776] && _0x20aa5600[_0x3e20b776] == _0x20aa5600[_0x472384ee])
            {
                _0x04e05960 = Paytable[_0x20aa5600[_0x2ea18c16]];
                _0x68c8645b[_0x2ea18c16] = true;
                _0x68c8645b[_0x3e20b776] = true;
                _0x68c8645b[_0x472384ee] = true;
                if (_0x04e05960 > _0x91d73237)
                {
                    _0x91d73237 = _0x04e05960;
                    _0xf027dd9c = _0x20aa5600[_0x2ea18c16];
                }
            }
            else if (_0x20aa5600[_0x2ea18c16] == TopPairSymbol && _0x20aa5600[_0x3e20b776] == TopPairSymbol)
            {
                _0x04e05960 = TopPairMultiplier;
                _0x68c8645b[_0x2ea18c16] = true;
                _0x68c8645b[_0x3e20b776] = true;
            }
            else if (_0x20aa5600[_0x3e20b776] == TopPairSymbol && _0x20aa5600[_0x472384ee] == TopPairSymbol)
            {
                _0x04e05960 = TopPairMultiplier;
                _0x68c8645b[_0x3e20b776] = true;
                _0x68c8645b[_0x472384ee] = true;
            }

            if (_0x04e05960 > 0f)
            {
                _0x5a1da9d9++;
                _0xa491bc16 += (int)(stake * _0x04e05960);
            }
        }

        _0xa491bc16 = (int)(_0xa491bc16 * _0x89a61012);
        return new _0x45fae2d6()._0x92ef9e5c(_0xa491bc16, _0x5a1da9d9, _0xf027dd9c, _0x68c8645b);
    }

    public static string SymbolName(int _0x85e9cd1a)
    {
        if (_0x85e9cd1a == 0)
        {
            return _0xb3969fd2._0x2ebaae1b(new byte[4] { 216, 212, 210, 213 }, 155);
        }

        if (_0x85e9cd1a == 1)
        {
            return _0xb3969fd2._0x2ebaae1b(new byte[5] { 0, 3, 6, 5, 7 }, 66);
        }

        if (_0x85e9cd1a == 2)
        {
            return _0xb3969fd2._0x2ebaae1b(new byte[4] { 102, 107, 103, 122 }, 42);
        }

        if (_0x85e9cd1a == 3)
        {
            return _0xb3969fd2._0x2ebaae1b(new byte[4] { 62, 36, 42, 35 }, 109);
        }

        return _0xb3969fd2._0x2ebaae1b(new byte[4] { 136, 155, 139, 130 }, 206);
    }

    public const int LineCount = 5;
    public static int[] Weights(int _0xa931a7d4)
    {
        if (_0xa931a7d4 == 0)
        {
            return _0x54333969;
        }

        return _0xa931a7d4 == 1 ? _0x6e28164d : _0x4b3981bb;
    }

    public const int SymbolCount = 5;
    public static string WeightName(int _0xef0ecc57)
    {
        if (_0xef0ecc57 == 0)
        {
            return _0xb3969fd2._0x2ebaae1b(new byte[4] { 6, 15, 11, 4 }, 74);
        }

        return _0xef0ecc57 == 1 ? _0xb3969fd2._0x2ebaae1b(new byte[4] { 126, 109, 126, 117 }, 59) : _0xb3969fd2._0x2ebaae1b(new byte[4] { 193, 218, 208, 219 }, 147);
    }

    private static readonly int[] _0x54333969 =
    {
        7,
        15,
        22,
        26,
        30
    };
    public const float TopPairMultiplier = 1f;
    /// <summary>Nine symbol indices, cell order left to right then top to bottom.</summary>
    public static int[] Spin(System.Random _0x3c90f7fd, int _0xa3e71152)
    {
        int[] _0xf5be3968 = Weights(_0xa3e71152);
        int _0xd79ea7ab = 0;
        for (int _0x120afb4f = 0; _0x120afb4f < _0xf5be3968.Length; _0x120afb4f++)
        {
            _0xd79ea7ab += _0xf5be3968[_0x120afb4f];
        }

        int[] _0x9cc287f2 = new int[Columns * Rows];
        for (int _0xeacd5ab3 = 0; _0xeacd5ab3 < _0x9cc287f2.Length; _0xeacd5ab3++)
        {
            int _0xfab28bec = _0x3c90f7fd.Next(0, _0xd79ea7ab);
            int _0x2c09b5ed = _0xf5be3968.Length - 1;
            for (int _0xb6d17da1 = 0; _0xb6d17da1 < _0xf5be3968.Length; _0xb6d17da1++)
            {
                _0xfab28bec -= _0xf5be3968[_0xb6d17da1];
                if (_0xfab28bec < 0)
                {
                    _0x2c09b5ed = _0xb6d17da1;
                    break;
                }
            }

            _0x9cc287f2[_0xeacd5ab3] = _0x2c09b5ed;
        }

        return _0x9cc287f2;
    }

    public const int Columns = 3;
    public static readonly int[] Stakes =
    {
        50,
        100,
        250
    };
    private static readonly int[] _0x5ca6402e =
    {
        0,
        1,
        2, // top row
        3,
        4,
        5, // middle row
        6,
        7,
        8, // bottom row
        0,
        4,
        8, // falling diagonal
        6,
        4,
        2 // rising diagonal
    };
    public const int TopUpCredits = 250;
    private static readonly int[] _0x4b3981bb =
    {
        18,
        20,
        20,
        20,
        22
    };
    /// <summary>Multiplier of the stake for three of a kind on one line, by symbol index.</summary>
    public static readonly float[] Paytable =
    {
        8f,
        6f,
        4f,
        3f,
        2f
    };
    public const int Rows = 3;
    /// <summary>
    /// Two adjacent COIN symbols on a line return the stake. Only the top symbol pays a
    /// pair: letting any pair pay made nine spins in ten a win, which leaves the win moment
    /// meaning nothing and the gold that marks it on screen all the time. Measured over
    /// 300k spins per table this gives a hit on roughly one spin in three and returns
    /// 91 / 93 / 115 per cent of stake on LEAN / EVEN / RICH, so a route holds its balance
    /// instead of draining - which is the point of a free-credit game that must never
    /// dead-end (rule C.5).
    /// </summary>
    public const int TopPairSymbol = 0;
    private static readonly int[] _0x6e28164d =
    {
        12,
        18,
        21,
        23,
        26
    };
}

internal static class _0xb3969fd2
{
    internal static string _0x2ebaae1b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}