using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three popups this game uses - PAUSE (6), WIN (7) and LOSE (8).
///
/// Each one is fetched by its SETTINGS index, never by name, and every child the template
/// put inside it is deactivated before this game's own card goes in. That is deliberate:
/// the stock card carries ten buttons laid out for another game, static rows reading
/// "Score:" and "Reward:" that this game has no values for, and an Image with no sprite on
/// the close control, which Unity draws as a solid white rectangle. Re-laying all of that
/// out is more work than replacing it, and leaves more to go wrong.
///
/// Every button here is captioned for what it does and wired through a lambda, so the
/// obfuscator renames the call together with the method (rules C.1, C.3 and C.17).
/// </summary>
public sealed class _0xc4dbdaea : MonoBehaviour
{
    private void _0x07cbf76c(RectTransform _0x996daa5b, float _0xea00c4a3, string _0x939465af, Color _0x46792362, UnityEngine.Events.UnityAction _0xc292752f)
    {
        _0xaefb2489.Cta(_0x996daa5b, _0x27772432._0xbc3ae54d(new byte[9] { 55, 8, 23, 38, 4, 19, 14, 8, 9 }, 103), _0xea00c4a3, 0.14f, 440f, 140f, this._0x880f647b.Plate, _0x46792362, _0x939465af, 40f, _0x662d66c6.Cream, this._0xd2b07554, _0xc292752f);
    }

    /// <summary>Empties the template card and returns this game's own card inside it.</summary>
    private RectTransform _0x9fe8d13d(_0xac76c53b _0xa4ea1dcb, string _0xbfd842a2)
    {
        if (_0xa4ea1dcb == null || _0xa4ea1dcb.Content == null)
        {
            return null;
        }

        Transform _0x7728feae = _0xa4ea1dcb.Content.transform;
        for (int _0x3bd29e63 = _0x7728feae.childCount - 1; _0x3bd29e63 >= 0; _0x3bd29e63--)
        {
            _0x7728feae.GetChild(_0x3bd29e63).gameObject.SetActive(false);
        }

        // Those labels sit behind a deactivated branch now, but they are the fields the
        // engine itself writes into, so they carry this game's wording rather than the
        // stock rows in case anything ever re-enables them.
        if (_0xa4ea1dcb.ContentHeaderText != null)
        {
            _0xa4ea1dcb.ContentHeaderText.text = _0xbfd842a2;
        }

        if (_0xa4ea1dcb.ContentMainText != null)
        {
            _0xa4ea1dcb.ContentMainText.text = "";
        }

        if (_0xa4ea1dcb.ContentAdditionalText != null)
        {
            _0xa4ea1dcb.ContentAdditionalText.text = "";
        }

        Image _0xd0bdddb4 = _0xaefb2489.Plate(_0x7728feae, _0x27772432._0xbc3ae54d(new byte[7] { 207, 240, 239, 220, 254, 237, 251 }, 159), 0.5f, 0.55f, 1060f, 1100f, this._0x880f647b.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.98f), 2.4f);
        _0xaefb2489.Plate(_0xd0bdddb4.rectTransform, _0x27772432._0xbc3ae54d(new byte[10] { 212, 235, 244, 199, 229, 246, 224, 214, 237, 233 }, 132), 0.5f, 0.5f, 1012f, 1052f, this._0x880f647b.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.32f), 2.8f);
        _0xaefb2489.Picture(_0xd0bdddb4.rectTransform, _0x27772432._0xbc3ae54d(new byte[7] { 172, 147, 140, 177, 157, 142, 151 }, 252), 0.5f, 0.655f, 200f, 200f, this._0x880f647b.Emblem, Color.white);
        return _0xd0bdddb4.rectTransform;
    }

    public void _0xd7d4516d(int _0xa48d8242, int _0xbbca0a59, int _0xc531bdca)
    {
        if (this._0xbfe59a93 != null)
        {
            this._0xbfe59a93.text = _0x27772432._0xbc3ae54d(new byte[12] { 182, 171, 177, 176, 161, 196, 180, 165, 177, 183, 161, 160 }, 228);
        }

        if (this._0x1f0a9b8f != null)
        {
            this._0x1f0a9b8f.text = _0x27772432._0xbc3ae54d(new byte[5] { 239, 232, 243, 236, 156 }, 188) + _0xa48d8242 + _0x27772432._0xbc3ae54d(new byte[4] { 218, 181, 188, 218 }, 250) + _0xbbca0a59 + _0x27772432._0xbc3ae54d(new byte[1] { 131 }, 137) + _0xf4914d3b.Money(_0xc531bdca) + _0x27772432._0xbc3ae54d(new byte[8] { 244, 151, 134, 145, 144, 157, 128, 135 }, 212);
        }

        _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.PAUSE);
    }

    private TextMeshProUGUI _0x7be00bcd;
    private TextMeshProUGUI _0x1e4d754c(RectTransform _0x08482393, string _0xf13a2b27)
    {
        return _0xaefb2489.Label(_0x08482393, _0x27772432._0xbc3ae54d(new byte[7] { 18, 45, 50, 12, 45, 54, 39 }, 66), _0xf13a2b27, 0.5f, 0.31f, 960f, 76f, 30f, _0x662d66c6.TextMuted, this._0xd2b07554, TextAlignmentOptions.Center);
    }

    private void _0x585152c9()
    {
        _0xbbace369.Instance._0xd6d594b0();
        this._0xa74d06ad._0xaab268b7();
    }

    private void _0xfca6e595()
    {
        _0xbbace369.Instance._0xd6d594b0();
        this._0xa74d06ad._0xb7bf78ce();
    }

    private TextMeshProUGUI _0x31e77f96;
    private void _0xf79fbb0a()
    {
        this._0xa74d06ad._0x5d5079b7();
    }

    private _0x3e5a25c6 _0xa74d06ad;
    private TextMeshProUGUI _0x2192f559;
    private TextMeshProUGUI _0x1f0a9b8f;
    private TextMeshProUGUI _0x9da1210c;
    private void _0x3d553a31()
    {
        this._0xa74d06ad._0xd955e19a();
    }

    public void _0x27f7d64a(int _0xa6d2f14c, int _0xfc5bca11, int _0x79533a11)
    {
        if (this._0x2192f559 != null)
        {
            this._0x2192f559.text = _0xa6d2f14c + _0x27772432._0xbc3ae54d(new byte[4] { 37, 74, 67, 37 }, 5) + _0xfc5bca11 + _0x27772432._0xbc3ae54d(new byte[7] { 216, 171, 172, 183, 168, 171, 242 }, 248) + _0xf4914d3b.Money(_0x79533a11) + _0x27772432._0xbc3ae54d(new byte[8] { 191, 220, 205, 218, 219, 214, 203, 204 }, 159);
        }

        _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.LOSE);
    }

    private TextMeshProUGUI _0xbfe59a93;
    private TextMeshProUGUI _0x527e3b70(RectTransform _0xd4b08587, string _0x4a0f93c8)
    {
        return _0xaefb2489.Label(_0xd4b08587, _0x27772432._0xbc3ae54d(new byte[9] { 196, 251, 228, 220, 241, 245, 240, 241, 230 }, 148), _0x4a0f93c8, 0.5f, 0.855f, 920f, 90f, 52f, _0x662d66c6.Gold, this._0xd2b07554, TextAlignmentOptions.Center);
    }

    public void _0x9be78baf(int _0x684edaf0, int _0x6acb31dd, int _0xcd1a8dc6)
    {
        if (this._0x31e77f96 != null)
        {
            this._0x31e77f96.text = _0x27772432._0xbc3ae54d(new byte[13] { 79, 82, 72, 73, 88, 61, 94, 81, 88, 92, 79, 88, 89 }, 29);
        }

        if (this._0x9da1210c != null)
        {
            this._0x9da1210c.text = _0x684edaf0 + _0x27772432._0xbc3ae54d(new byte[8] { 151, 228, 227, 248, 231, 228, 189, 156 }, 183) + _0xf4914d3b.Money(_0x6acb31dd) + _0x27772432._0xbc3ae54d(new byte[8] { 19, 112, 97, 118, 119, 122, 103, 96 }, 51);
        }

        if (this._0x7be00bcd != null)
        {
            this._0x7be00bcd.text = _0xcd1a8dc6 > 0 ? _0xcd1a8dc6 + _0x27772432._0xbc3ae54d(new byte[24] { 147, 253, 246, 228, 147, 241, 242, 247, 244, 246, 224, 147, 250, 253, 147, 231, 251, 246, 147, 242, 255, 241, 230, 254 }, 179) : _0x27772432._0xbc3ae54d(new byte[27] { 206, 207, 160, 206, 197, 215, 160, 194, 193, 196, 199, 197, 211, 160, 207, 206, 160, 212, 200, 201, 211, 160, 210, 207, 213, 212, 197 }, 128);
        }

        _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.WIN);
    }

    private void _0x62625c55(RectTransform _0x72c57cfd, UnityEngine.Events.UnityAction _0x903dc524)
    {
        _0xaefb2489.IconCta(_0x72c57cfd, _0x27772432._0xbc3ae54d(new byte[8] { 57, 6, 25, 42, 5, 6, 26, 12 }, 105), 0.93f, 0.93f, 96f, this._0x880f647b.ButtonRound, this._0x880f647b.IconBack, Color.white, _0x662d66c6.Cream, _0x903dc524);
    }

    private _0x9a4ef192 _0x880f647b;
    private TMP_FontAsset _0xd2b07554;
    private TextMeshProUGUI _0x243e15d3(RectTransform _0x68c6f632, string _0xe8efb053)
    {
        return _0xaefb2489.Label(_0x68c6f632, _0x27772432._0xbc3ae54d(new byte[7] { 107, 84, 75, 121, 84, 95, 66 }, 59), _0xe8efb053, 0.5f, 0.44f, 940f, 110f, 40f, _0x662d66c6.Cream, this._0xd2b07554, TextAlignmentOptions.Center);
    }

    public void _0xe698748f(_0x9a4ef192 _0x2ffd7cfb, TMP_FontAsset _0x58d8fe67, _0x3e5a25c6 _0x2078e9e6)
    {
        this._0x880f647b = _0x2ffd7cfb;
        this._0xd2b07554 = _0x58d8fe67;
        this._0xa74d06ad = _0x2078e9e6;
        _0xbbace369 _0x64fea47f = _0xbbace369.Instance;
        if (_0x64fea47f == null)
        {
            return;
        }

        _0xac76c53b _0xdeed3929 = _0x64fea47f._0xf40baff2(_0x7d9c5f21._0x991ac867.PAUSE);
        RectTransform _0xde0f6d49 = this._0x9fe8d13d(_0xdeed3929, _0x27772432._0xbc3ae54d(new byte[12] { 135, 154, 128, 129, 144, 245, 133, 148, 128, 134, 144, 145 }, 213));
        if (_0xde0f6d49 != null)
        {
            this._0xbfe59a93 = this._0x527e3b70(_0xde0f6d49, _0x27772432._0xbc3ae54d(new byte[12] { 200, 213, 207, 206, 223, 186, 202, 219, 207, 201, 223, 222 }, 154));
            this._0x1f0a9b8f = this._0x243e15d3(_0xde0f6d49, "");
            this._0x1e4d754c(_0xde0f6d49, _0x27772432._0xbc3ae54d(new byte[25] { 25, 13, 26, 26, 127, 15, 19, 30, 6, 127, 114, 127, 17, 16, 127, 13, 26, 30, 19, 127, 18, 16, 17, 26, 6 }, 95));
            this._0x07cbf76c(_0xde0f6d49, 0.275f, _0x27772432._0xbc3ae54d(new byte[6] { 38, 49, 39, 33, 57, 49 }, 116), _0x662d66c6.Gold, () => this._0x585152c9());
            this._0x07cbf76c(_0xde0f6d49, 0.725f, _0x27772432._0xbc3ae54d(new byte[9] { 12, 7, 13, 105, 27, 6, 28, 29, 12 }, 73), _0x662d66c6.Fade(_0x662d66c6.SignRed, 0.92f), () => this._0xfca6e595());
            this._0x62625c55(_0xde0f6d49, () => this._0x585152c9());
        }

        _0xac76c53b _0xab0069c3 = _0x64fea47f._0xf40baff2(_0x7d9c5f21._0x991ac867.WIN);
        RectTransform _0xb32e7cba = this._0x9fe8d13d(_0xab0069c3, _0x27772432._0xbc3ae54d(new byte[13] { 102, 123, 97, 96, 113, 20, 119, 120, 113, 117, 102, 113, 112 }, 52));
        if (_0xb32e7cba != null)
        {
            this._0x31e77f96 = this._0x527e3b70(_0xb32e7cba, _0x27772432._0xbc3ae54d(new byte[13] { 252, 225, 251, 250, 235, 142, 237, 226, 235, 239, 252, 235, 234 }, 174));
            this._0x9da1210c = this._0x243e15d3(_0xb32e7cba, "");
            this._0x7be00bcd = this._0x1e4d754c(_0xb32e7cba, "");
            this._0x07cbf76c(_0xb32e7cba, 0.275f, _0x27772432._0xbc3ae54d(new byte[10] { 88, 83, 78, 66, 54, 68, 89, 67, 66, 83 }, 22), _0x662d66c6.Gold, () => this._0x3d553a31());
            this._0x07cbf76c(_0xb32e7cba, 0.725f, _0x27772432._0xbc3ae54d(new byte[5] { 222, 221, 208, 208, 203 }, 146), _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), () => this._0xf79fbb0a());
        }

        _0xac76c53b _0xa84c91d2 = _0x64fea47f._0xf40baff2(_0x7d9c5f21._0x991ac867.LOSE);
        RectTransform _0x87492891 = this._0x9fe8d13d(_0xa84c91d2, _0x27772432._0xbc3ae54d(new byte[11] { 251, 230, 252, 253, 236, 137, 236, 231, 237, 236, 237 }, 169));
        if (_0x87492891 != null)
        {
            this._0x527e3b70(_0x87492891, _0x27772432._0xbc3ae54d(new byte[11] { 130, 159, 133, 132, 149, 240, 149, 158, 148, 149, 148 }, 208));
            this._0x2192f559 = this._0x243e15d3(_0x87492891, "");
            this._0x1e4d754c(_0x87492891, _0x27772432._0xbc3ae54d(new byte[37] { 107, 127, 104, 104, 13, 110, 127, 104, 105, 100, 121, 126, 13, 127, 104, 107, 100, 97, 97, 13, 98, 99, 13, 121, 101, 104, 13, 99, 104, 117, 121, 13, 127, 98, 120, 121, 104 }, 45));
            this._0x07cbf76c(_0x87492891, 0.275f, _0x27772432._0xbc3ae54d(new byte[11] { 151, 129, 154, 133, 150, 243, 146, 148, 146, 154, 157 }, 211), _0x662d66c6.Gold, () => this._0x3d553a31());
            this._0x07cbf76c(_0x87492891, 0.725f, _0x27772432._0xbc3ae54d(new byte[5] { 170, 169, 164, 164, 191 }, 230), _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), () => this._0xf79fbb0a());
        }
    }
}

internal static class _0x27772432
{
    internal static string _0xbc3ae54d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}