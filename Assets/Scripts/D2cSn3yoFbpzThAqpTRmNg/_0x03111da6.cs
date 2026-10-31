using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The badge album: twelve slots in a three by four grid. A slot the player owns is drawn
/// in its route colour; a locked one keeps the same silhouette, dimmed, with the word
/// LOCKED under it, so the grid reads as a collection rather than as missing art.
///
/// With nothing owned the grid is replaced by one themed line - never a blank screen.
/// </summary>
public sealed class _0x03111da6 : MonoBehaviour
{
    private RectTransform _0x4f4652c0;
    private static readonly Color[] _0xfab942b8 =
    {
        new Color(0.831373f, 0.686275f, 0.215686f, 1f),
        new Color(0.298039f, 0.525490f, 1f, 1f),
        new Color(0.949020f, 0.462745f, 0.168627f, 1f),
        new Color(0.184314f, 0.627451f, 0.415686f, 1f),
        new Color(0.960784f, 0.843137f, 0.478431f, 1f),
        new Color(0.784314f, 0.270588f, 0.184314f, 1f)
    };
    private _0x9a4ef192 _0x7d2417b5;
    public void _0x860dcf65()
    {
        if (this._0x4f4652c0 == null)
        {
            return;
        }

        for (int _0xaa85f89d = this._0x4f4652c0.childCount - 1; _0xaa85f89d >= 0; _0xaa85f89d--)
        {
            Destroy(this._0x4f4652c0.GetChild(_0xaa85f89d).gameObject);
        }

        int _0x20e7d58d = _0xf4914d3b.OwnedBadges();
        if (this._0xfc6cf329 != null)
        {
            this._0xfc6cf329.text = _0x20e7d58d + _0xbb54c7a9._0x7157e94f(new byte[3] { 102, 105, 102 }, 70) + _0xf4914d3b.BadgeCount + _0xbb54c7a9._0x7157e94f(new byte[10] { 18, 113, 125, 126, 126, 119, 113, 102, 119, 118 }, 50);
        }

        if (_0x20e7d58d == 0)
        {
            _0xab5b90a8.Empty(this._0x4f4652c0, this._0xe1eed4f1, _0xbb54c7a9._0x7157e94f(new byte[40] { 218, 219, 180, 214, 213, 208, 211, 209, 199, 180, 205, 209, 192, 158, 208, 198, 221, 194, 209, 180, 213, 180, 198, 219, 193, 192, 209, 180, 192, 219, 180, 210, 221, 218, 208, 180, 192, 220, 209, 217 }, 148));
            return;
        }

        float[] _0x9d74d05f =
        {
            0.705f,
            0.565f,
            0.425f,
            0.285f
        };
        float[] _0x2122a4ac =
        {
            0.235f,
            0.5f,
            0.765f
        };
        for (int _0x45f9e974 = 0; _0x45f9e974 < _0xf4914d3b.BadgeCount; _0x45f9e974++)
        {
            bool _0x74c5598e = _0xf4914d3b.HasBadge(_0x45f9e974);
            float _0x7bf71c04 = _0x2122a4ac[_0x45f9e974 % 3];
            float _0xf3c800e8 = _0x9d74d05f[_0x45f9e974 / 3];
            Image _0x0ac2f9ba = _0xaefb2489.Plate(this._0x4f4652c0, _0xbb54c7a9._0x7157e94f(new byte[9] { 200, 229, 235, 252, 228, 218, 229, 230, 253 }, 137), _0x7bf71c04, _0xf3c800e8, 280f, 280f, this._0x7d2417b5.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, _0x74c5598e ? 0.95f : 0.6f), 2.2f);
            _0xaefb2489.Picture(_0x0ac2f9ba.rectTransform, _0xbb54c7a9._0x7157e94f(new byte[10] { 138, 167, 169, 190, 166, 137, 170, 175, 172, 174 }, 203), 0.5f, 0.6f, 170f, 170f, this._0x7d2417b5._0x7e4623dc(1), _0x74c5598e ? _0xfab942b8[_0x45f9e974 % _0xfab942b8.Length] : new Color(0.109804f, 0.109804f, 0.141176f, 0.35f));
            _0xaefb2489.Label(_0x0ac2f9ba.rectTransform, _0xbb54c7a9._0x7157e94f(new byte[9] { 106, 71, 73, 94, 70, 101, 74, 70, 78 }, 43), _0x74c5598e ? _0xf1b9bfb1[_0x45f9e974] : _0xbb54c7a9._0x7157e94f(new byte[6] { 44, 47, 35, 43, 37, 36 }, 96), 0.5f, 0.16f, 250f, 56f, 26f, _0x74c5598e ? _0x662d66c6.Cream : _0x662d66c6.TextMuted, this._0xe1eed4f1, TextAlignmentOptions.Center);
        }
    }

    private static readonly string[] _0xf1b9bfb1 =
    {
        _0xbb54c7a9._0x7157e94f(new byte[6] { 46, 40, 39, 61, 59, 48 }, 105),
        _0xbb54c7a9._0x7157e94f(new byte[5] { 131, 143, 128, 135, 144 }, 194),
        _0xbb54c7a9._0x7157e94f(new byte[6] { 220, 208, 221, 222, 211, 203 }, 159),
        _0xbb54c7a9._0x7157e94f(new byte[7] { 151, 154, 149, 143, 158, 137, 149 }, 219),
        _0xbb54c7a9._0x7157e94f(new byte[4] { 192, 209, 215, 207 }, 132),
        _0xbb54c7a9._0x7157e94f(new byte[4] { 103, 100, 97, 102 }, 52),
        _0xbb54c7a9._0x7157e94f(new byte[6] { 48, 52, 32, 51, 51, 56 }, 97),
        _0xbb54c7a9._0x7157e94f(new byte[6] { 192, 218, 212, 221, 210, 223 }, 147),
        _0xbb54c7a9._0x7157e94f(new byte[6] { 60, 59, 56, 56, 59, 35 }, 116),
        _0xbb54c7a9._0x7157e94f(new byte[5] { 130, 138, 133, 130, 149 }, 199),
        _0xbb54c7a9._0x7157e94f(new byte[7] { 139, 148, 156, 153, 136, 158, 137 }, 221),
        _0xbb54c7a9._0x7157e94f(new byte[4] { 113, 120, 108, 117 }, 57)
    };
    private TextMeshProUGUI _0xfc6cf329;
    private TMP_FontAsset _0xe1eed4f1;
    public void _0xdf31f18c(_0xda5171dd _0x1010ab4c)
    {
        this._0x7d2417b5 = _0x1010ab4c._0xd24f5652;
        this._0xe1eed4f1 = _0x1010ab4c._0x88e5de05;
        RectTransform _0x3794b86c = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0x3794b86c, this._0x7d2417b5, this._0xe1eed4f1, _0xbb54c7a9._0x7157e94f(new byte[12] { 207, 210, 200, 201, 216, 189, 223, 220, 217, 218, 216, 206 }, 157), () => _0x1010ab4c._0x13a54356());
        this._0xfc6cf329 = _0xaefb2489.Label(_0x3794b86c, _0xbb54c7a9._0x7157e94f(new byte[10] { 213, 248, 246, 225, 249, 215, 251, 225, 250, 224 }, 148), "", 0.5f, 0.825f, 900f, 70f, 40f, _0x662d66c6.Gold, this._0xe1eed4f1, TextAlignmentOptions.Center);
        this._0x4f4652c0 = _0xaefb2489.Full(_0x3794b86c, _0xbb54c7a9._0x7157e94f(new byte[9] { 241, 220, 210, 197, 221, 247, 194, 217, 212 }, 176));
        this._0x860dcf65();
    }
}

internal static class _0xbb54c7a9
{
    internal static string _0x7157e94f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}