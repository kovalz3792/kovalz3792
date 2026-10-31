using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Five stat cards.
///
/// Each card carries a coloured accent dot, a large number and a caption - and no raster
/// icon. Generated art arrives with the subject at a different size and offset inside every
/// file, so a row of such icons never lines up; colour carries the meaning instead, and the
/// number is the point of a stat card anyway.
///
/// A fresh install has nothing to show, so the grid is replaced by one themed line.
/// </summary>
public sealed class _0x09a9c1eb : MonoBehaviour
{
    public void _0xf7b034d7()
    {
        if (this._0xd6f9d626 == null)
        {
            return;
        }

        for (int _0x460f2a25 = this._0xd6f9d626.childCount - 1; _0x460f2a25 >= 0; _0x460f2a25--)
        {
            Destroy(this._0xd6f9d626.GetChild(_0x460f2a25).gameObject);
        }

        int _0x22880be4 = _0xf4914d3b._0xf107532a;
        int _0x7674b24c = _0xf4914d3b._0x2a892773;
        if (_0x22880be4 == 0 && _0x7674b24c == 0)
        {
            _0xab5b90a8.Empty(this._0xd6f9d626, this._0xbfea4851, _0x3cbda654._0x877fa029(new byte[44] { 52, 53, 90, 40, 53, 47, 46, 63, 41, 90, 57, 54, 63, 59, 40, 63, 62, 90, 35, 63, 46, 112, 41, 46, 59, 40, 46, 90, 35, 53, 47, 40, 90, 60, 51, 40, 41, 46, 90, 40, 53, 47, 46, 63 }, 122));
            return;
        }

        this._0x1799c288(0.265f, 0.70f, 500f, _0x3cbda654._0x877fa029(new byte[14] { 26, 7, 29, 28, 13, 27, 104, 11, 4, 13, 9, 26, 13, 12 }, 72), _0x22880be4, _0x662d66c6.Gold);
        this._0x1799c288(0.735f, 0.70f, 500f, _0x3cbda654._0x877fa029(new byte[10] { 184, 191, 164, 187, 184, 203, 184, 187, 190, 165 }, 235), _0x7674b24c, _0x662d66c6.CobaltGlow);
        this._0x1799c288(0.265f, 0.515f, 500f, _0x3cbda654._0x877fa029(new byte[6] { 232, 235, 238, 237, 239, 249 }, 170), _0xf4914d3b.OwnedBadges(), _0x662d66c6.SignGreen);
        this._0x1799c288(0.735f, 0.515f, 500f, _0x3cbda654._0x877fa029(new byte[11] { 153, 158, 136, 143, 251, 139, 154, 130, 148, 142, 143 }, 219), _0xf4914d3b._0xfd792853, _0x662d66c6.SunsetOrange);
        this._0x1799c288(0.5f, 0.33f, 1060f, _0x3cbda654._0x877fa029(new byte[14] { 193, 215, 208, 208, 199, 204, 214, 162, 209, 214, 208, 199, 195, 201 }, 130), _0xf4914d3b._0x14c4bbdd, _0x662d66c6.GoldLight);
        _0xaefb2489.Label(this._0xd6f9d626, _0x3cbda654._0x877fa029(new byte[11] { 152, 186, 167, 174, 161, 164, 173, 134, 167, 188, 173 }, 200), _0x3cbda654._0x877fa029(new byte[47] { 72, 69, 69, 41, 79, 64, 78, 92, 91, 76, 90, 41, 72, 91, 76, 41, 69, 70, 74, 72, 69, 41, 72, 71, 77, 41, 74, 70, 92, 71, 93, 41, 79, 91, 76, 76, 41, 89, 69, 72, 80, 41, 70, 71, 69, 80, 39 }, 9), 0.5f, 0.2f, 1040f, 64f, 26f, _0x662d66c6.TextMuted, this._0xbfea4851, TextAlignmentOptions.Center);
    }

    private _0x9a4ef192 _0x804b5ad6;
    private void _0x1799c288(float _0x4c7ad66b, float _0x95c9805e, float _0x4037635b, string _0xbd84b32a, int _0x39edec0b, Color _0x965f05da)
    {
        Image _0xb5d69bca = _0xaefb2489.Plate(this._0xd6f9d626, _0x3cbda654._0x877fa029(new byte[11] { 224, 194, 223, 214, 217, 220, 213, 243, 209, 194, 212 }, 176), _0x4c7ad66b, _0x95c9805e, _0x4037635b, 220f, this._0x804b5ad6.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), 2.4f);
        RectTransform _0x059a7ca0 = _0xb5d69bca.rectTransform;
        _0xaefb2489.Plate(_0x059a7ca0, _0x3cbda654._0x877fa029(new byte[13] { 92, 126, 99, 106, 101, 96, 105, 77, 111, 111, 105, 98, 120 }, 12), 0.5f, 0.88f, 36f, 8f, this._0x804b5ad6.Plate, _0x965f05da, 0.6f);
        _0xaefb2489.Label(_0x059a7ca0, _0x3cbda654._0x877fa029(new byte[12] { 169, 139, 150, 159, 144, 149, 156, 175, 152, 149, 140, 156 }, 249), _0x39edec0b > 0 ? _0xf4914d3b.Money(_0x39edec0b) : _0x3cbda654._0x877fa029(new byte[1] { 146 }, 191), 0.5f, 0.58f, _0x4037635b - 80f, 100f, 64f, _0x965f05da, this._0xbfea4851, TextAlignmentOptions.Center);
        _0xaefb2489.Label(_0x059a7ca0, _0x3cbda654._0x877fa029(new byte[14] { 5, 39, 58, 51, 60, 57, 48, 22, 52, 37, 33, 60, 58, 59 }, 85), _0xbd84b32a, 0.5f, 0.22f, _0x4037635b - 60f, 56f, 26f, _0x662d66c6.TextMuted, this._0xbfea4851, TextAlignmentOptions.Center);
    }

    private TMP_FontAsset _0xbfea4851;
    private RectTransform _0xd6f9d626;
    public void _0x85ad6e92(_0xda5171dd _0x289175bd)
    {
        this._0x804b5ad6 = _0x289175bd._0xd24f5652;
        this._0xbfea4851 = _0x289175bd._0x88e5de05;
        RectTransform _0xb10516dc = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0xb10516dc, this._0x804b5ad6, this._0xbfea4851, _0x3cbda654._0x877fa029(new byte[14] { 219, 205, 214, 201, 218, 205, 191, 207, 205, 208, 217, 214, 211, 218 }, 159), () => _0x289175bd._0x13a54356());
        this._0xd6f9d626 = _0xaefb2489.Full(_0xb10516dc, _0x3cbda654._0x877fa029(new byte[11] { 27, 57, 36, 45, 34, 39, 46, 12, 57, 34, 47 }, 75));
        this._0xf7b034d7();
    }
}

internal static class _0x3cbda654
{
    internal static string _0x877fa029(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}