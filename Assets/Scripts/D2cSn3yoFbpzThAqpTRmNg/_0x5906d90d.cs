using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three rotating daily missions.
///
/// The row layout keeps two bands that never share x-space (rule C.25): the indicator
/// gutter is centred at 86 with a width of 56, and the text column starts at 160 - a clear
/// 46 units past the gutter's right edge - and ends at 780, well inside the card. Left
/// alignment only moves glyphs inside their rectangle; it does nothing to stop the
/// rectangle itself sliding under an icon, which is how these rows normally break.
/// </summary>
public sealed class _0x5906d90d : MonoBehaviour
{
    public void _0x65c304bb(_0xda5171dd _0x1b6ad2c5)
    {
        this._0x9ba802a4 = _0x1b6ad2c5;
        this._0x8a1a45b1 = _0x1b6ad2c5._0xd24f5652;
        this._0xa6c5ec94 = _0x1b6ad2c5._0x88e5de05;
        RectTransform _0x3b882c84 = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0x3b882c84, this._0x8a1a45b1, this._0xa6c5ec94, _0x14f5d702._0x9a0710bb(new byte[14] { 53, 40, 50, 51, 34, 71, 42, 46, 52, 52, 46, 40, 41, 52 }, 103), () => _0x1b6ad2c5._0x13a54356());
        this._0x508b8155 = _0xaefb2489.Full(_0x3b882c84, _0x14f5d702._0x9a0710bb(new byte[11] { 149, 177, 171, 171, 177, 183, 182, 138, 183, 175, 171 }, 216));
        _0xaefb2489.Label(_0x3b882c84, _0x14f5d702._0x9a0710bb(new byte[16] { 198, 226, 248, 248, 226, 228, 229, 248, 205, 228, 228, 255, 229, 228, 255, 238 }, 139), _0x14f5d702._0x9a0710bb(new byte[70] { 114, 118, 108, 108, 118, 112, 113, 31, 109, 122, 104, 126, 109, 123, 108, 31, 126, 109, 122, 31, 121, 109, 122, 122, 31, 124, 109, 122, 123, 118, 107, 108, 17, 31, 107, 119, 122, 102, 31, 124, 126, 113, 113, 112, 107, 31, 125, 122, 31, 125, 112, 106, 120, 119, 107, 31, 112, 109, 31, 124, 126, 108, 119, 122, 123, 31, 112, 106, 107, 17 }, 63), 0.5f, 0.175f, 1040f, 70f, 26f, _0x662d66c6.TextMuted, this._0xa6c5ec94, TextAlignmentOptions.Center);
        this._0xedc334af();
    }

    private RectTransform _0x508b8155;
    private _0x9a4ef192 _0x8a1a45b1;
    /// <summary>Rebuilds the rows, so a claim is visible the moment it happens.</summary>
    public void _0xedc334af()
    {
        if (this._0x508b8155 == null)
        {
            return;
        }

        for (int _0xf367b9fe = this._0x508b8155.childCount - 1; _0xf367b9fe >= 0; _0xf367b9fe--)
        {
            Destroy(this._0x508b8155.GetChild(_0xf367b9fe).gameObject);
        }

        _0x6ab3f9d5.EnsureToday();
        if (_0xf4914d3b._0xecd6f2a5 < 0)
        {
            _0xab5b90a8.Empty(this._0x508b8155, this._0xa6c5ec94, _0x14f5d702._0x9a0710bb(new byte[28] { 185, 189, 167, 167, 189, 187, 186, 167, 212, 166, 177, 178, 166, 177, 167, 188, 212, 181, 160, 212, 185, 189, 176, 186, 189, 179, 188, 160 }, 244));
            return;
        }

        float[] _0x530e930c =
        {
            0.70f,
            0.52f,
            0.34f
        };
        for (int _0x64eeb263 = 0; _0x64eeb263 < _0x6ab3f9d5.Slots; _0x64eeb263++)
        {
            this._0x72fc1227(_0x530e930c[_0x64eeb263], _0x64eeb263);
        }
    }

    private void _0x72fc1227(float _0xb1556f44, int _0x54c85554)
    {
        int _0x7a6806d6 = _0x6ab3f9d5.Target(_0x54c85554);
        int _0x7ca23e5e = _0x6ab3f9d5.Progress(_0x54c85554);
        bool _0xb3b175f1 = _0x7ca23e5e >= _0x7a6806d6;
        int _0x9210f78b = _0x7ca23e5e > _0x7a6806d6 ? _0x7a6806d6 : _0x7ca23e5e;
        Image _0x75d1630d = _0xaefb2489.Plate(this._0x508b8155, _0x14f5d702._0x9a0710bb(new byte[10] { 66, 102, 124, 124, 102, 96, 97, 93, 96, 120 }, 15), 0.5f, _0xb1556f44, 1060f, 220f, this._0x8a1a45b1.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), 2.4f);
        RectTransform _0xc884fcb2 = _0x75d1630d.rectTransform;
        // The gutter: 56 wide, centred at 86, and nothing else ever lives in it.
        _0xaefb2489.Plate(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[16] { 34, 6, 28, 28, 6, 0, 1, 61, 6, 1, 8, 59, 29, 14, 12, 4 }, 111), 0.0811f, 0.5f, 56f, 56f, this._0x8a1a45b1.Plate, _0x662d66c6.TarWarm, 0.4f);
        float _0x896b4e6c = _0x7a6806d6 > 0 ? (float)_0x9210f78b / _0x7a6806d6 : 0f;
        float _0x4d88d719 = 16f + 34f * _0x896b4e6c;
        _0xaefb2489.Plate(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[15] { 199, 227, 249, 249, 227, 229, 228, 216, 227, 228, 237, 204, 227, 230, 230 }, 138), 0.0811f, 0.5f, _0x4d88d719, _0x4d88d719, this._0x8a1a45b1.Plate, _0xb3b175f1 ? _0x662d66c6.Gold : _0x662d66c6.CobaltGlow, 0.4f);
        _0xaefb2489.Label(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[12] { 179, 151, 141, 141, 151, 145, 144, 170, 151, 138, 146, 155 }, 254), _0x6ab3f9d5.Title(_0x54c85554), 0.4434f, 0.66f, 620f, 66f, 38f, _0xb3b175f1 ? _0x662d66c6.Gold : _0x662d66c6.Cream, this._0xa6c5ec94, TextAlignmentOptions.Left);
        _0xaefb2489.Label(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[15] { 134, 162, 184, 184, 162, 164, 165, 155, 185, 164, 172, 185, 174, 184, 184 }, 203), _0x9210f78b + _0x14f5d702._0x9a0710bb(new byte[3] { 241, 254, 241 }, 209) + _0x7a6806d6 + _0x14f5d702._0x9a0710bb(new byte[4] { 133, 133, 133, 142 }, 165) + _0x6ab3f9d5.Reward(_0x54c85554) + _0x14f5d702._0x9a0710bb(new byte[8] { 112, 19, 2, 21, 20, 25, 4, 3 }, 80), 0.4434f, 0.32f, 620f, 56f, 28f, _0x662d66c6.TextMuted, this._0xa6c5ec94, TextAlignmentOptions.Left);
        if (_0xb3b175f1)
        {
            _0xaefb2489.Cta(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[12] { 205, 233, 243, 243, 233, 239, 238, 195, 236, 225, 233, 237 }, 128), 0.858f, 0.5f, 220f, 84f, this._0x8a1a45b1.Plate, _0x662d66c6.Gold, _0x14f5d702._0x9a0710bb(new byte[5] { 44, 35, 46, 38, 34 }, 111), 30f, _0x662d66c6.Cream, this._0xa6c5ec94, () => this._0xe8578d02(_0x54c85554));
        }
        else
        {
            _0xaefb2489.Label(_0xc884fcb2, _0x14f5d702._0x9a0710bb(new byte[13] { 157, 185, 163, 163, 185, 191, 190, 156, 191, 179, 187, 181, 180 }, 208), _0x14f5d702._0x9a0710bb(new byte[11] { 45, 42, 68, 52, 54, 43, 35, 54, 33, 55, 55 }, 100), 0.858f, 0.5f, 220f, 60f, 26f, _0x662d66c6.TextMuted, this._0xa6c5ec94, TextAlignmentOptions.Center);
        }
    }

    private void _0xe8578d02(int _0xc6d865c7)
    {
        if (!_0x6ab3f9d5.IsComplete(_0xc6d865c7))
        {
            return;
        }

        _0xf4914d3b.SetMissionProgress(_0xc6d865c7, 0);
        this._0x9ba802a4._0xfdf4460d(_0x6ab3f9d5.Reward(_0xc6d865c7));
        this._0xedc334af();
    }

    private TMP_FontAsset _0xa6c5ec94;
    private _0xda5171dd _0x9ba802a4;
}

internal static class _0x14f5d702
{
    internal static string _0x9a0710bb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}