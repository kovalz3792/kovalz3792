using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The roadside decorator. Choosing a set changes four visible things at once - the live
/// preview strip below re-props and re-tints, the chosen card takes a gold outline, the
/// choice is persisted and the props in the game scene follow on the next run - so the tap
/// confirms itself on a screenshot rather than only in a label (rule C.7).
/// </summary>
public sealed class _0x5c39f428 : MonoBehaviour
{
    public void _0xe077ca67(_0xda5171dd _0x24213679)
    {
        this._0xc8a64d81 = _0x24213679._0xd24f5652;
        this._0x79bab02c = _0x24213679._0x88e5de05;
        RectTransform _0x3131516e = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0x3131516e, this._0xc8a64d81, this._0x79bab02c, _0x3cdb0e43._0x9e86e0be(new byte[14] { 19, 14, 0, 5, 18, 8, 5, 4, 97, 5, 4, 2, 14, 19 }, 65), () => _0x24213679._0x13a54356());
        float[] _0xa224ac19 =
        {
            0.21f,
            0.5f,
            0.79f
        };
        for (int _0xed597451 = 0; _0xed597451 < SetCount; _0xed597451++)
        {
            int _0x832b01c6 = _0xed597451;
            Image _0xc09bc125 = _0xaefb2489.Plate(_0x3131516e, _0x3cdb0e43._0x9e86e0be(new byte[9] { 83, 114, 116, 120, 101, 84, 118, 101, 115 }, 23), _0xa224ac19[_0xed597451], 0.58f, 340f, 420f, this._0xc8a64d81.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), 2.2f);
            this._0x19d9d793[_0xed597451] = _0xc09bc125;
            _0xaefb2489.Picture(_0xc09bc125.rectTransform, _0x3cdb0e43._0x9e86e0be(new byte[8] { 8, 41, 47, 35, 62, 13, 62, 56 }, 76), 0.5f, 0.62f, 220f, 220f, this._0xc8a64d81._0x7e4623dc(2 + _0xed597451), _0x7dd52184[_0xed597451]);
            _0xaefb2489.Label(_0xc09bc125.rectTransform, _0x3cdb0e43._0x9e86e0be(new byte[9] { 174, 143, 137, 133, 152, 164, 139, 135, 143 }, 234), _0x45ae936a[_0xed597451], 0.5f, 0.17f, 300f, 64f, 30f, _0x662d66c6.Cream, this._0x79bab02c, TextAlignmentOptions.Center);
            RectTransform _0x33742b70 = _0xaefb2489.Full(_0xc09bc125.rectTransform, _0x3cdb0e43._0x9e86e0be(new byte[8] { 123, 90, 92, 80, 77, 119, 86, 75 }, 63));
            Image _0xc3eda7c8 = _0x33742b70.gameObject.AddComponent<Image>();
            _0xc3eda7c8.color = new Color(1f, 1f, 1f, 0f);
            _0xc3eda7c8.raycastTarget = true;
            Button _0x6b3c8573 = _0x33742b70.gameObject.AddComponent<Button>();
            _0x6b3c8573.targetGraphic = _0xc3eda7c8;
            _0x6b3c8573.onClick.AddListener(() => this._0xebda8077(_0x832b01c6));
            _0x33742b70.gameObject.AddComponent<_0xccfd05ae>()._0x606fe1eb(_0xc09bc125.rectTransform);
        }

        Image _0x0613c075 = _0xaefb2489.Plate(_0x3131516e, _0x3cdb0e43._0x9e86e0be(new byte[12] { 129, 160, 166, 170, 183, 149, 183, 160, 179, 172, 160, 178 }, 197), 0.5f, 0.33f, 1060f, 300f, this._0xc8a64d81.Plate, _0x662d66c6.Fade(_0x662d66c6.TarWarm, 0.96f), 2.4f);
        for (int _0x6a0e7b86 = 0; _0x6a0e7b86 < this._0xa6481c84.Length; _0x6a0e7b86++)
        {
            float _0x6c87e75d = 0.16f + 0.227f * _0x6a0e7b86;
            this._0xa6481c84[_0x6a0e7b86] = _0xaefb2489.Picture(_0x0613c075.rectTransform, _0x3cdb0e43._0x9e86e0be(new byte[9] { 49, 16, 22, 26, 7, 37, 7, 26, 5 }, 117), _0x6c87e75d, 0.56f, 150f, 150f, this._0xc8a64d81._0x7e4623dc(2), Color.white);
        }

        this._0x20528b60 = _0xaefb2489.Label(_0x0613c075.rectTransform, _0x3cdb0e43._0x9e86e0be(new byte[12] { 26, 59, 61, 49, 44, 29, 63, 46, 42, 55, 49, 48 }, 94), "", 0.5f, 0.16f, 900f, 56f, 28f, _0x662d66c6.TextMuted, this._0x79bab02c, TextAlignmentOptions.Center);
        _0xaefb2489.Label(_0x3131516e, _0x3cdb0e43._0x9e86e0be(new byte[9] { 164, 133, 131, 143, 146, 174, 143, 148, 133 }, 224), _0x3cdb0e43._0x9e86e0be(new byte[57] { 216, 217, 223, 211, 206, 188, 213, 207, 188, 218, 206, 217, 217, 188, 221, 210, 216, 188, 223, 212, 221, 210, 219, 217, 207, 188, 200, 212, 217, 188, 206, 211, 221, 216, 207, 213, 216, 217, 188, 211, 210, 188, 197, 211, 201, 206, 188, 210, 217, 196, 200, 188, 206, 211, 201, 200, 217 }, 156), 0.5f, 0.2f, 1040f, 64f, 26f, _0x662d66c6.TextMuted, this._0x79bab02c, TextAlignmentOptions.Center);
        this._0x522a19a4();
    }

    public void _0x522a19a4()
    {
        int _0xe6f66af3 = _0xf4914d3b._0x51ab4991;
        for (int _0xacfab66f = 0; _0xacfab66f < this._0x19d9d793.Length; _0xacfab66f++)
        {
            if (this._0x19d9d793[_0xacfab66f] == null)
            {
                continue;
            }

            this._0x19d9d793[_0xacfab66f].color = _0xacfab66f == _0xe6f66af3 ? _0x662d66c6.Fade(_0x7dd52184[_0xacfab66f], 0.28f) : _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f);
        }

        for (int _0xc2037cc3 = 0; _0xc2037cc3 < this._0xa6481c84.Length; _0xc2037cc3++)
        {
            if (this._0xa6481c84[_0xc2037cc3] == null)
            {
                continue;
            }

            this._0xa6481c84[_0xc2037cc3].sprite = this._0xc8a64d81._0x7e4623dc(2 + _0xe6f66af3);
            this._0xa6481c84[_0xc2037cc3].preserveAspect = true;
            this._0xa6481c84[_0xc2037cc3].color = _0x7dd52184[_0xe6f66af3];
        }

        if (this._0x20528b60 != null)
        {
            this._0x20528b60.text = _0x3cdb0e43._0x9e86e0be(new byte[15] { 214, 203, 197, 192, 215, 205, 192, 193, 164, 215, 193, 208, 164, 169, 164 }, 132) + _0x45ae936a[_0xe6f66af3];
        }
    }

    private readonly Image[] _0xa6481c84 = new Image[4];
    public static Color TintOf(int _0x251b6886)
    {
        return _0x7dd52184[_0x251b6886 < 0 || _0x251b6886 >= SetCount ? 0 : _0x251b6886];
    }

    private TMP_FontAsset _0x79bab02c;
    private void _0xebda8077(int _0x6ee64ed6)
    {
        _0xf4914d3b._0x51ab4991 = _0x6ee64ed6;
        this._0x522a19a4();
    }

    public static string NameOf(int _0x2a03259d)
    {
        return _0x45ae936a[_0x2a03259d < 0 || _0x2a03259d >= SetCount ? 0 : _0x2a03259d];
    }

    private static readonly string[] _0x45ae936a =
    {
        _0x3cdb0e43._0x9e86e0be(new byte[5] { 155, 151, 150, 157, 139 }, 216),
        _0x3cdb0e43._0x9e86e0be(new byte[9] { 192, 203, 193, 192, 174, 207, 220, 205, 198 }, 142),
        _0x3cdb0e43._0x9e86e0be(new byte[11] { 243, 255, 240, 247, 224, 146, 254, 243, 255, 226, 225 }, 178)
    };
    private static readonly Color[] _0x7dd52184 =
    {
        new Color(0.949020f, 0.462745f, 0.168627f, 1f),
        new Color(0.298039f, 0.525490f, 1f, 1f),
        new Color(0.960784f, 0.843137f, 0.478431f, 1f)
    };
    private _0x9a4ef192 _0xc8a64d81;
    public const int SetCount = 3;
    private TextMeshProUGUI _0x20528b60;
    private readonly Image[] _0x19d9d793 = new Image[SetCount];
}

internal static class _0x3cdb0e43
{
    internal static string _0x9e86e0be(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}