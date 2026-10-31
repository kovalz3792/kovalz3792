using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The whole route on one screen: eighteen markers in three fixed rows, colour-coded by
/// what each stop will do. There is no scrolling and no drag anywhere in this app - the
/// entire control scheme is a tap - so the ribbon is sized to fit instead of panning.
///
/// It carries the second route-into-game button. The template driver on the lobby Play
/// slot cannot be reused here, so this one asks BasicController for the scene by INDEX,
/// which is the only scene reference obfuscation cannot break.
/// </summary>
public sealed class _0xc0ee4864 : MonoBehaviour
{
    private string _0x4a41d9ba(int _0xd25bb1c3)
    {
        if (_0xd25bb1c3 == _0xf7978a15.KindBadge)
        {
            return _0x3ac3065d._0x4e0782d7(new byte[5] { 93, 94, 91, 88, 90 }, 31);
        }

        if (_0xd25bb1c3 == _0xf7978a15.KindGift)
        {
            return _0x3ac3065d._0x4e0782d7(new byte[4] { 33, 47, 32, 50 }, 102);
        }

        if (_0xd25bb1c3 == _0xf7978a15.KindDetour)
        {
            return _0x3ac3065d._0x4e0782d7(new byte[6] { 129, 128, 145, 138, 144, 151 }, 197);
        }

        return _0x3ac3065d._0x4e0782d7(new byte[3] { 199, 214, 206 }, 151);
    }

    public void _0x5d573e0b(_0xda5171dd _0x0bce1335)
    {
        _0x9a4ef192 _0x21673594 = _0x0bce1335._0xd24f5652;
        TMP_FontAsset _0x1c09d1f8 = _0x0bce1335._0x88e5de05;
        RectTransform _0xa5c32cdd = this.GetComponent<RectTransform>();
        _0x3394b55a _0x021842e2 = _0x0bce1335._0x7b4794ef;
        string _0x614cb8a9 = _0x021842e2.IsFallback ? _0x3ac3065d._0x4e0782d7(new byte[12] { 77, 78, 76, 68, 90, 95, 47, 93, 64, 90, 91, 74 }, 15) : _0x3ac3065d._0x4e0782d7(new byte[9] { 176, 173, 183, 182, 167, 194, 175, 163, 178 }, 226);
        _0xab5b90a8.Open(_0xa5c32cdd, _0x21673594, _0x1c09d1f8, _0x614cb8a9, () => _0x0bce1335._0x13a54356());
        _0xaefb2489.Label(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[11] { 162, 142, 159, 188, 154, 141, 155, 134, 155, 131, 138 }, 239), _0x021842e2.SignName, 0.5f, 0.825f, 980f, 70f, 40f, _0x662d66c6.Gold, _0x1c09d1f8, TextAlignmentOptions.Center);
        float[] _0xfbf06078 =
        {
            0.715f,
            0.560f,
            0.405f
        };
        int _0x5de509ef = _0x021842e2._0xe7956500 < 18 ? _0x021842e2._0xe7956500 : 18;
        for (int _0xe11adaa9 = 0; _0xe11adaa9 < _0x5de509ef; _0xe11adaa9++)
        {
            int _0x97e67c6b = _0xe11adaa9 / 6;
            int _0x5cd1781a = _0xe11adaa9 % 6;
            float _0x52eff1c6 = 0.13f + 0.148f * _0x5cd1781a;
            float _0xdd94195d = _0xfbf06078[_0x97e67c6b];
            _0xf7978a15 _0xa019eaa2 = _0x021842e2.Stops[_0xe11adaa9];
            _0xaefb2489.Plate(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[9] { 14, 34, 51, 14, 34, 49, 40, 38, 49 }, 67), _0x52eff1c6, _0xdd94195d, 140f, 140f, _0x21673594.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.96f), 0.8f);
            _0xaefb2489.Plate(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[12] { 19, 63, 46, 19, 63, 44, 53, 59, 44, 26, 49, 42 }, 94), _0x52eff1c6, _0xdd94195d + 0.0235f, 44f, 10f, _0x21673594.Plate, this._0x45ee60a7(_0xa019eaa2.Kind), 1.4f);
            _0xaefb2489.Label(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[14] { 43, 7, 22, 43, 7, 20, 13, 3, 20, 47, 8, 2, 3, 30 }, 102), (_0xe11adaa9 + 1).ToString(), _0x52eff1c6, _0xdd94195d - 0.004f, 130f, 70f, 36f, _0x662d66c6.Cream, _0x1c09d1f8, TextAlignmentOptions.Center);
            _0xaefb2489.Label(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[13] { 218, 246, 231, 218, 246, 229, 252, 242, 229, 220, 254, 249, 243 }, 151), this._0x4a41d9ba(_0xa019eaa2.Kind), _0x52eff1c6, _0xdd94195d - 0.0345f, 160f, 44f, 26f, _0x662d66c6.TextMuted, _0x1c09d1f8, TextAlignmentOptions.Center);
        }

        _0xaefb2489.Picture(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[6] { 176, 156, 141, 171, 156, 147 }, 253), 0.13f, 0.775f, 120f, 120f, _0x21673594._0x7e4623dc(3), Color.white);
        this._0x1bae462d(_0xa5c32cdd, _0x21673594, _0x1c09d1f8, 0.13f, _0x3ac3065d._0x4e0782d7(new byte[6] { 48, 33, 57, 47, 53, 52 }, 96), _0x662d66c6.Gold);
        this._0x1bae462d(_0xa5c32cdd, _0x21673594, _0x1c09d1f8, 0.37f, _0x3ac3065d._0x4e0782d7(new byte[5] { 177, 178, 183, 180, 182 }, 243), _0x662d66c6.CobaltGlow);
        this._0x1bae462d(_0xa5c32cdd, _0x21673594, _0x1c09d1f8, 0.63f, _0x3ac3065d._0x4e0782d7(new byte[4] { 233, 231, 232, 250 }, 174), _0x662d66c6.SignGreen);
        this._0x1bae462d(_0xa5c32cdd, _0x21673594, _0x1c09d1f8, 0.87f, _0x3ac3065d._0x4e0782d7(new byte[6] { 125, 124, 109, 118, 108, 107 }, 57), _0x662d66c6.SunsetOrange);
        _0xaefb2489.Cta(_0xa5c32cdd, _0x3ac3065d._0x4e0782d7(new byte[8] { 102, 74, 91, 111, 89, 66, 93, 78 }, 43), 0.5f, 0.155f, 760f, 164f, _0x21673594.ButtonRect, Color.white, _0x3ac3065d._0x4e0782d7(new byte[11] { 99, 117, 110, 113, 98, 7, 117, 104, 114, 115, 98 }, 39), 54f, _0x662d66c6.Cream, _0x1c09d1f8, () => _0x5b07c2df.Instance._0xac2de253(_0x7d9c5f21._0x4c653446.SCENE_1));
    }

    private void _0x1bae462d(RectTransform _0x91f57441, _0x9a4ef192 _0x5022cc45, TMP_FontAsset _0x1a000264, float _0x248e08b2, string _0x55493a00, Color _0x59e621ff)
    {
        Image _0x1f64fc71 = _0xaefb2489.Plate(_0x91f57441, _0x3ac3065d._0x4e0782d7(new byte[9] { 1, 45, 60, 0, 41, 43, 41, 34, 40 }, 76), _0x248e08b2, 0.305f, 250f, 86f, _0x5022cc45.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.96f), 2.2f);
        _0xaefb2489.Plate(_0x1f64fc71.rectTransform, _0x3ac3065d._0x4e0782d7(new byte[12] { 180, 152, 137, 181, 156, 158, 156, 151, 157, 189, 150, 141 }, 249), 0.12f, 0.5f, 26f, 26f, _0x5022cc45.Plate, _0x59e621ff, 0.6f);
        _0xaefb2489.Label(_0x1f64fc71.rectTransform, _0x3ac3065d._0x4e0782d7(new byte[13] { 120, 84, 69, 121, 80, 82, 80, 91, 81, 97, 80, 77, 65 }, 53), _0x55493a00, 0.58f, 0.5f, 166f, 52f, 28f, _0x662d66c6.Cream, _0x1a000264, TextAlignmentOptions.Center);
    }

    private Color _0x45ee60a7(int _0xda7124b0)
    {
        if (_0xda7124b0 == _0xf7978a15.KindBadge)
        {
            return _0x662d66c6.CobaltGlow;
        }

        if (_0xda7124b0 == _0xf7978a15.KindGift)
        {
            return _0x662d66c6.SignGreen;
        }

        if (_0xda7124b0 == _0xf7978a15.KindDetour)
        {
            return _0x662d66c6.SunsetOrange;
        }

        return _0x662d66c6.Gold;
    }
}

internal static class _0x3ac3065d
{
    internal static string _0x4e0782d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}